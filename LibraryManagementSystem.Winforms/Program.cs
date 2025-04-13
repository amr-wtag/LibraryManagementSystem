using System;
using System.Windows.Forms;
using LibraryManagementSystem.Winforms.Properties;

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

                // Optional: Persist the token for future sessions
                // Remove this line if you want to keep it in-memory only
                Settings.Default.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Authentication.LoginForms());
        }
    }