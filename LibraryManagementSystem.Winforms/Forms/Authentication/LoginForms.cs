using System.Text;
using System.Text.Json;
using LibraryManagementSystem.Winforms.Forms.Dashboard;
using LibraryManagementSystem.Winforms.Models;

namespace LibraryManagementSystem.Winforms.Views.Authentication;

public partial class LoginForms : Form
{
    public LoginForms()
    {
        InitializeComponent();
        this.Load += LoginForms_Load;
    }

    private void LoginForms_Load(object? sender, EventArgs e)
    {
        var token = Properties.Settings.Default.JwtToken;

        if (!string.IsNullOrEmpty(token))
        {
            /*var mainForm = new Form1();
            mainForm.Show();*/
            var dashboardListForm = new DashboardForm();
            this.Hide();
            dashboardListForm.Show();
        }
    }

    private async void loginButton_click(object sender, EventArgs e)
    {
        var userName = txtUserName.Text;
        var password = txtPassword.Text;

        using var client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:5049"); // Replace with your actual API


        var loginData = new LoginDto
        {
            UserName = userName,
            Password = password
        };

        var json = JsonSerializer.Serialize(loginData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            var response = await client.PostAsync("/api/auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonSerializer.Deserialize<LoginResponse>(
                    responseString,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save token for future requests (if needed)
                Properties.Settings.Default.JwtToken = loginResponse?.Token;
                Properties.Settings.Default.Save();

                // var mainForm = new Form1();
                // mainForm.Show();
                // this.Hide();
                var dashboardListForm = new DashboardForm();
                dashboardListForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
