using LibraryManagementSystem.Winforms.Forms.Dashboard;
using LibraryManagementSystem.Winforms.Properties;
using LibraryManagementSystem.Winforms.Views.Authentication;

namespace LibraryManagementSystem.Winforms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        // ✅ Read JWT from environment variable
        string jwtFromEnv = Environment.GetEnvironmentVariable("JWT_TOKEN");

        if (!string.IsNullOrWhiteSpace(jwtFromEnv))
        {
            Settings.Default.JwtToken = jwtFromEnv;

            Settings.Default.Save();
        }

        if (!string.IsNullOrWhiteSpace(Settings.Default.JwtToken))
        {
            Application.Run(new DashboardForm()); // Go straight to dashboard
        }
        else
        {
            Application.Run(new LoginForms()); // Show login screen
        }
    }
}