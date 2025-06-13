using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.BookReservations;
using LibraryManagementSystem.Winforms.Models.Users;
using System.Net.Http.Json;
using System.Text.Json;

namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    public partial class AddReservationForm : Form
    {

        private bool isInitializing = true;

        public AddReservationForm()
        {
            InitializeComponent();
            this.Load += AddReservationForm_Load;

            userDropdownControl.SelectedIndexChanged += async (s, e) =>
            {
                if (isInitializing) return;

                if (userDropdownControl.SelectedOption != null &&
                    Guid.TryParse(userDropdownControl.SelectedOption.Value?.ToString(), out _))
                {
                    await ShowBookReservationsAsync();
                }
            };
        }

        private async void AddReservationForm_Load(object sender, EventArgs e)
        {
            isInitializing = true;
            await LoadUserOptionAsync();
            await bookReservation.SetBookOptions(); // Populate book dropdown on load

            isInitializing = false;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private async Task ShowBookReservationsAsync()
        {
            using var client = ApiClientHelper.CreateClient();
            var response = await client.GetAsync($"bookreservation?userId={userDropdownControl.SelectedOption.Value}&status=Issued");

            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var bookReservationsWrapper = JsonSerializer.Deserialize<BookReservationListResponse>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var bookReservations = bookReservationsWrapper?.BookReservations;

                if (bookReservations != null)
                {
                    var tasks = bookReservations.Select(async bookReservation =>
                    {


                        return new BookReservationDisplayModal
                        {
                            Id = bookReservation.Id,
                            IssuedDate = bookReservation.IssuedDate,
                            DueDate = bookReservation.DueDate,
                            ReturnDate = bookReservation.ReturnDate,
                            Status = bookReservation.Status,
                            BookTitle = bookReservation?.Book?.Title,
                        };
                    });

                    var displayBookReservations = await Task.WhenAll(tasks);

                    bookReservationDataGridView.DataSource = displayBookReservations.ToList();

                }

            }
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            // Validate user
            if (userDropdownControl.SelectedOption == null ||
                !Guid.TryParse(userDropdownControl.SelectedOption.Value?.ToString(), out Guid userId))
            {
                MessageBox.Show("Please select a valid user.");
                return;
            }

            // Validate book
            var bookIdStr = bookReservation.SelectedBookId;
            if (string.IsNullOrWhiteSpace(bookIdStr) || !Guid.TryParse(bookIdStr, out Guid bookId))
            {
                MessageBox.Show("Please select a valid book.");
                return;
            }

            // Prepare request
            var payload = new ReservationRequest
            {
                UserId = userId,
                Reservations = new List<ReservationItem>
                {
                    new ReservationItem
                    {
                        BookId = bookId,
                        DueDate = DateTime.SpecifyKind(bookReservation.DueDate, DateTimeKind.Utc)
                    }
                }
            };

            using var client = ApiClientHelper.CreateClient();

            try
            {
                var response = await client.PostAsJsonAsync("BookReservation", payload);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Reservation submitted successfully!");
                    await ShowBookReservationsAsync();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
