using System.ComponentModel;
using LibraryManagementSystem.Winforms.Component;

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
        booksButton = new Button();
        usersButton = new Button();
        contentPanel = new Panel();
        buttonPanel = new Panel();
        bookReservation = new Button();
        logOutButton = new Button();
        buttonPanel.SuspendLayout();
        SuspendLayout();
        // 
        // booksButton
        // 
        booksButton.FlatAppearance.BorderSize = 0;
        booksButton.FlatStyle = FlatStyle.Flat;
        booksButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        booksButton.ForeColor = Color.White;
        booksButton.Location = new Point(82, 21);
        booksButton.Margin = new Padding(4, 2, 4, 2);
        booksButton.Name = "booksButton";
        booksButton.Size = new Size(175, 87);
        booksButton.TabIndex = 0;
        booksButton.Text = "📚 Books";
        booksButton.Click += BooksButton_Click;
        // 
        // usersButton
        // 
        usersButton.FlatAppearance.BorderSize = 0;
        usersButton.FlatStyle = FlatStyle.Flat;
        usersButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        usersButton.ForeColor = Color.White;
        usersButton.Location = new Point(56, 102);
        usersButton.Margin = new Padding(6, 4, 6, 4);
        usersButton.Name = "usersButton";
        usersButton.Size = new Size(201, 64);
        usersButton.TabIndex = 1;
        usersButton.Text = "👤 Users";
        usersButton.Click += UsersButton_Click;
        // 
        // contentPanel
        // 
        contentPanel.BackColor = Color.White;
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(334, 0);
        contentPanel.Margin = new Padding(4, 2, 4, 2);
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(1226, 1086);
        contentPanel.TabIndex = 0;
        // 
        // buttonPanel
        // 
        buttonPanel.BackColor = Color.FromArgb(44, 62, 80);
        buttonPanel.Controls.Add(usersButton);
        buttonPanel.Controls.Add(bookReservation);
        buttonPanel.Controls.Add(logOutButton);
        buttonPanel.Controls.Add(booksButton);
        buttonPanel.Dock = DockStyle.Left;
        buttonPanel.Location = new Point(0, 0);
        buttonPanel.Margin = new Padding(4, 2, 4, 2);
        buttonPanel.Name = "buttonPanel";
        buttonPanel.Size = new Size(334, 1086);
        buttonPanel.TabIndex = 1;
        // 
        // bookReservation
        // 
        bookReservation.AutoEllipsis = true;
        bookReservation.FlatAppearance.BorderSize = 0;
        bookReservation.FlatStyle = FlatStyle.Flat;
        bookReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        bookReservation.ForeColor = Color.White;
        bookReservation.Location = new Point(17, 196);
        bookReservation.Margin = new Padding(4, 2, 4, 2);
        bookReservation.Name = "bookReservation";
        bookReservation.Size = new Size(312, 98);
        bookReservation.TabIndex = 3;
        bookReservation.Text = "BookReservation";
        bookReservation.UseVisualStyleBackColor = true;
        // 
        // logOutButton
        // 
        logOutButton.AutoEllipsis = true;
        logOutButton.FlatAppearance.BorderSize = 0;
        logOutButton.FlatStyle = FlatStyle.Flat;
        logOutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        logOutButton.ForeColor = Color.White;
        logOutButton.Location = new Point(26, 310);
        logOutButton.Margin = new Padding(4, 2, 4, 2);
        logOutButton.Name = "logOutButton";
        logOutButton.Size = new Size(271, 85);
        logOutButton.TabIndex = 2;
        logOutButton.Text = "LogOut";
        logOutButton.UseVisualStyleBackColor = true;
        // 
        // DashboardForm
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(1560, 1086);
        Controls.Add(contentPanel);
        Controls.Add(buttonPanel);
        FormBorderStyle = FormBorderStyle.Sizable;
        Margin = new Padding(4, 2, 4, 2);
        MaximizeBox = true;
        Name = "DashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Library Dashboard";
        buttonPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
    private Panel buttonPanel;
    private Button logOutButton;
    private Button bookReservation;
}
