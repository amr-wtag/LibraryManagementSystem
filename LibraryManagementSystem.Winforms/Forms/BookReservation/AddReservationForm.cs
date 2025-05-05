using System.Text.Json;
using LibraryManagementSystem.Winforms.Forms.BookReservation.BookReservationRow;
using LibraryManagementSystem.Winforms.helpers;
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
                AutoSize = true,
                Width = bookReservationPanel.Width - 25,
                Padding = new Padding(2),
                AutoSizeMode = AutoSizeMode.GrowAndShrink
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
    }
}
