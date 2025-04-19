using System.ComponentModel;

namespace LibraryManagementSystem.Winforms.Forms.Dashboard;

partial class DashboardForm
{
    private IContainer components = null;

    private Panel contentPanel;
    private Button booksButton;
    private Button usersButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.booksButton = new Button();
        this.usersButton = new Button();
        this.contentPanel = new Panel();
        var buttonPanel = new Panel();

        // 
        // DashboardForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 600);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "DashboardForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Library Dashboard";

        // 
        // buttonPanel
        // 
        buttonPanel.Dock = DockStyle.Top;
        buttonPanel.Height = 60;
        buttonPanel.BackColor = Color.FromArgb(44, 62, 80);

        // 
        // booksButton
        // 
        this.booksButton.Text = "📚 Books";
        this.booksButton.FlatStyle = FlatStyle.Flat;
        this.booksButton.ForeColor = Color.White;
        this.booksButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.booksButton.Size = new Size(150, 40);
        this.booksButton.Location = new Point(20, 10);
        this.booksButton.FlatAppearance.BorderSize = 0;
        this.booksButton.Click += new EventHandler(this.BooksButton_Click);

        // 
        // usersButton
        // 
        this.usersButton.Text = "👤 Users";
        this.usersButton.FlatStyle = FlatStyle.Flat;
        this.usersButton.ForeColor = Color.White;
        this.usersButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.usersButton.Size = new Size(150, 40);
        this.usersButton.Location = new Point(190, 10);
        this.usersButton.FlatAppearance.BorderSize = 0;
        this.usersButton.Click += new EventHandler(this.UsersButton_Click);

        // 
        // contentPanel
        // 
        this.contentPanel.Dock = DockStyle.Fill;
        this.contentPanel.BackColor = Color.White;

        // Add buttons to buttonPanel
        buttonPanel.Controls.Add(this.booksButton);
        buttonPanel.Controls.Add(this.usersButton);

        // Add panels to form
        this.Controls.Add(this.contentPanel);
        this.Controls.Add(buttonPanel);

        this.ResumeLayout(false);
    }
}
