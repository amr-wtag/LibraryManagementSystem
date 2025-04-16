using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5049");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                var response = await client.GetAsync("/api/users");

                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var users = JsonSerializer.Deserialize<List<UserDisplayModal>>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    });
                    if (users != null && users.Any())
                    {
                        //DataGridViewUsers.DataSource = users;
                        MessageBox.Show("Users found.");
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
