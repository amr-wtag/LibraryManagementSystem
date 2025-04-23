using System.Net.Http.Headers;
using System.Text.Json;
using LibraryManagementSystem.Winforms.Forms.Books;
using LibraryManagementSystem.Winforms.Forms.Users;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Views.Authentication;

namespace LibraryManagementSystem.Winforms.Forms.Dashboard;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
        logOutButton.Click += logOutButton_Click;
    }

    private void BooksButton_Click(object sender, EventArgs e)
    {
        OpenChildForm(new BookListForm());
    }

    private void UsersButton_Click(object sender, EventArgs e)
    {
        OpenChildForm(new UserListForm());
    }

    private void OpenChildForm(Form childForm)
    {
        contentPanel.Controls.Clear();
        childForm.TopLevel = false;
        childForm.Dock = DockStyle.Fill;
        childForm.FormBorderStyle = FormBorderStyle.None;
        contentPanel.Controls.Add(childForm);
        childForm.Show();
    }

    private async void logOutButton_Click(object sender, EventArgs e)
    {
        var token = Properties.Settings.Default.JwtToken;

        if (string.IsNullOrEmpty(token))
        {
            MessageBox.Show("No token found. You are already logged out.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var client = ApiClientHelper.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        try
        {
            var response = await client.PostAsync("auth/logout", null);
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var json = JsonSerializer.Deserialize<JsonElement>(result);
                var message = json.GetProperty("message").GetString();

                MessageBox.Show(message ?? "Logged out successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Properties.Settings.Default.JwtToken = string.Empty;
                Properties.Settings.Default.Save();

                new LoginForms().Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Logout failed: " + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred:\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    private void multiSelectComboBox1_Load(object sender, EventArgs e)
    {
        var options = new List<DropDownOption>
    {
         new DropDownOption { Label = "Option 1", Value = 1 },
        new DropDownOption { Label = "Option 2", Value = 2 },
        new DropDownOption { Label = "Option 3", Value = 3 }
    };

    }
}
