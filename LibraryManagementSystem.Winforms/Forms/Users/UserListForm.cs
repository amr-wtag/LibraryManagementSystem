using System.Data;
using System.Text.Json;
using LibraryManagementSystem.Winforms.Models.Users;

namespace LibraryManagementSystem.Winforms.Forms.Users
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        private async void UserListForm_Load(object sender, EventArgs e)
        {
            await ShowUsersAsync();
        }

        public async Task ShowUsersAsync()
        {
            var token = Properties.Settings.Default.JwtToken;

            Console.WriteLine(new { token });

            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5049");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                var response = await client.GetAsync("/api/user");

                var result = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Status Code: {response.StatusCode}");
                Console.WriteLine($"Reason Phrase: {response.ReasonPhrase}");

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
                            Email = user.Email,
                            Role = user.Role,
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
