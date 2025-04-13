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

        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Login.Location = new System.Drawing.Point(564, 90);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(195, 86);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.userName.Location = new System.Drawing.Point(504, 286);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(197, 51);
            this.userName.TabIndex = 1;
            this.userName.Text = "UserName";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.password.Location = new System.Drawing.Point(504, 416);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(177, 51);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(504, 340);
            this.txtUserName.MinimumSize = new System.Drawing.Size(0, 60);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(316, 60);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(504, 488);
            this.txtPassword.MinimumSize = new System.Drawing.Size(0, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(321, 60);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(515, 646);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(185, 60);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_click);
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 940);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtUserName);
            this.Name = "LoginForms";
            this.Text = "LoginForms";
            this.ResumeLayout(false);
            this.PerformLayout();
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
