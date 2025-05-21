using System.Net.Http.Json;
using System.Text.Json;
using LibraryManagementSystem.Winforms.Forms.BookReservation.BookReservationRow;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.BookReservations;
using LibraryManagementSystem.Winforms.Models.Users;

namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    public partial class AddReservationForm : Form
    {
        private List<BookReservationRowControl> bookRows = new List<BookReservationRowControl>();

        public AddReservationForm()
        {
            InitializeComponent();
            this.Load += AddReservationForm_Load; // Hook into form load event
        }

        private async void AddReservationForm_Load(object sender, EventArgs e)
        {
            await LoadUserOptionAsync();

        }

        private async Task LoadUserOptionAsync()
        {
            using var client = ApiClientHelper.CreateClient();
            try
            {
                var response = await client.GetAsync("user/id-username");
                var result = await response.Content.ReadAsStringAsync();

                var responseObject = JsonSerializer.Deserialize<UserSummaryResponse>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var users = responseObject?.Values ?? new List<UserSummary>();

                var userOptions = users.Select(user => new DropDownOption
                {
                    Label = user.userName ?? string.Empty,
                    Value = user.Id
                }).ToList();



                userDropdownControl.SetOptions(userOptions);
                userDropdownControl.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void addReservation_Click(object sender, EventArgs e)
        {
            var row = new BookReservationRowControl();
            row.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            row.Width = bookReservationPanel.ClientSize.Width - 20;

            // Create a container to hold the row
            var container = new Panel
            {
                AutoSize = false,
                Width = bookReservationPanel.Width,
                Padding = new Padding(2),
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                MinimumSize = new Size(bookReservationPanel.Width, 0)
            };

            row.Dock = DockStyle.Fill;

            container.Controls.Add(row);
            bookReservationPanel.Controls.Add(container);
            bookRows.Add(row);

            // Hook up the row's internal [ - ] button event
            row.RemoveClicked += (s, args) =>
            {
                bookRows.Remove(row);
                bookReservationPanel.Controls.Remove(container);
                container.Dispose();
            };
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {

            if (userDropdownControl.SelectedOption == null ||
                !Guid.TryParse(userDropdownControl.SelectedOption.Value?.ToString(), out Guid userId))
            {
                MessageBox.Show("Please select a valid user.");
                return;
            }

            var reservations = new List<ReservationItem>();

            foreach (var row in bookRows)
            {
                if (!Guid.TryParse(row.SelectedBookId, out Guid bookId))
                {
                    MessageBox.Show("Please select a valid book in all rows.");
                    return;
                }

                reservations.Add(new ReservationItem
                {
                    BookId = bookId,
                    DueDate = DateTime.SpecifyKind(row.DueDate, DateTimeKind.Utc)
                });
            }

            var payload = new ReservationRequest
            {
                UserId = userId,
                Reservations = reservations
            };

            var json = JsonSerializer.Serialize(payload, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });

            using var client = ApiClientHelper.CreateClient();

            try
            {
                var response = await client.PostAsJsonAsync("BookReservation", payload); // Adjust endpoint as needed

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Reservation submitted successfully!");
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {response.StatusCode}\n{error}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }


    }
}
