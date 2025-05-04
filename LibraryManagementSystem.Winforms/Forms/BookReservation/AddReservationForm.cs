using System.Text.Json;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Users;

namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    public partial class AddReservationForm : Form
    {
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
    }
}
