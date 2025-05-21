using System.ComponentModel;

namespace LibraryManagementSystem.Winforms.Views.Authentication
{
    partial class LoginForms
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login = new System.Windows.Forms.Label();
            userName = new System.Windows.Forms.Label();
            password = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            loginButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new System.Drawing.Font("Segoe UI", 24F);
            Login.Location = new System.Drawing.Point(304, 42);
            Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Login.Name = "Login";
            Login.Size = new System.Drawing.Size(99, 45);
            Login.TabIndex = 0;
            Login.Text = "Login";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new System.Drawing.Font("Segoe UI", 14F);
            userName.Location = new System.Drawing.Point(271, 134);
            userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            userName.Name = "userName";
            userName.Size = new System.Drawing.Size(100, 25);
            userName.TabIndex = 1;
            userName.Text = "UserName";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new System.Drawing.Font("Segoe UI", 14F);
            password.Location = new System.Drawing.Point(271, 195);
            password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            password.Name = "password";
            password.Size = new System.Drawing.Size(91, 25);
            password.TabIndex = 2;
            password.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(271, 159);
            txtUserName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtUserName.MinimumSize = new System.Drawing.Size(4, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(172, 23);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtPassword.Location = new System.Drawing.Point(271, 229);
            txtPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtPassword.MinimumSize = new System.Drawing.Size(4, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(175, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new System.Drawing.Point(277, 303);
            loginButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(100, 28);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_click;
            // 
            // LoginForms
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(594, 379);
            Controls.Add(loginButton);
            Controls.Add(txtPassword);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(Login);
            Controls.Add(txtUserName);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Text = "LoginForms";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button loginButton;

        #endregion
    }
}
