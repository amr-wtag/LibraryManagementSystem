using System.Data;
using System.Text.Json;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Users;

namespace LibraryManagementSystem.Winforms.Forms.Users
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
            this.Load += UserListForm_Load;
        }

        private async void UserListForm_Load(object? sender, EventArgs e)

        {
            var token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                await ShowUsersAsync();
            }
            else
            {
                MessageBox.Show("No token found. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        public async Task ShowUsersAsync()
        {
            var token = Properties.Settings.Default.JwtToken;

            using var client = ApiClientHelper.CreateClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                var response = await client.GetAsync("user");

                var result = await response.Content.ReadAsStringAsync();


                if (response.IsSuccessStatusCode)
                {
                    var users = JsonSerializer.Deserialize<UserListResponse>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    });
                    if (users != null)
                    {
                        var displayUser = users?.Value.Select(user => new UserDisplayModal
                        {
                            FullName = user.FullName ?? "",
                            //Email = user.Email ?? "",
                            //Role = user.Role,
                        }).ToList();
                        DataGridViewUsers.DataSource = displayUser;
                        //MessageBox.Show($"Users found.{users}");
                    }
                    else
                    {
                        MessageBox.Show("No users found.");
                    }
                    //if(users != null)
                    //{
                    //    DataGridViewUsers.DataSource = users;
                    //}
                }
                else
                {
                    MessageBox.Show("Failed to fetch users");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
