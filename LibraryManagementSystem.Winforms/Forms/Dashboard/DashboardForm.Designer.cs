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
        dropdownControl1 = new DropdownControl();
        buttonPanel = new Panel();
        bookReservation = new Button();
        logOutButton = new Button();
        multiSelectComboBox1 = new MultiSelectComboBox();
        buttonPanel.SuspendLayout();
        SuspendLayout();
        // 
        // booksButton
        // 
        booksButton.FlatAppearance.BorderSize = 0;
        booksButton.FlatStyle = FlatStyle.Flat;
        booksButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        booksButton.ForeColor = Color.White;
        booksButton.Location = new Point(44, 10);
        booksButton.Margin = new Padding(2, 1, 2, 1);
        booksButton.Name = "booksButton";
        booksButton.Size = new Size(94, 41);
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
        usersButton.Location = new Point(30, 48);
        usersButton.Margin = new Padding(3, 2, 3, 2);
        usersButton.Name = "usersButton";
        usersButton.Size = new Size(108, 30);
        usersButton.TabIndex = 1;
        usersButton.Text = "👤 Users";
        usersButton.Click += UsersButton_Click;
        // 
        // contentPanel
        // 
        contentPanel.BackColor = Color.White;
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(180, 0);
        contentPanel.Margin = new Padding(2, 1, 2, 1);
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(660, 509);
        contentPanel.TabIndex = 0;
        // 
        // dropdownControl1
        // 
        dropdownControl1.BackColor = Color.Black;
        dropdownControl1.BackgroundImageLayout = ImageLayout.Center;
        dropdownControl1.ForeColor = Color.White;
        dropdownControl1.IsMultiSelect = false;
        dropdownControl1.Location = new Point(12, 164);
        dropdownControl1.Name = "dropdownControl1";
        dropdownControl1.Size = new Size(156, 114);
        dropdownControl1.TabIndex = 4;
        dropdownControl1.Load += dropdownControl1_Load;
        // 
        // buttonPanel
        // 
        buttonPanel.BackColor = Color.FromArgb(44, 62, 80);
        buttonPanel.Controls.Add(multiSelectComboBox1);
        buttonPanel.Controls.Add(dropdownControl1);
        buttonPanel.Controls.Add(usersButton);
        buttonPanel.Controls.Add(bookReservation);
        buttonPanel.Controls.Add(logOutButton);
        buttonPanel.Controls.Add(booksButton);
        buttonPanel.Dock = DockStyle.Left;
        buttonPanel.Location = new Point(0, 0);
        buttonPanel.Margin = new Padding(2, 1, 2, 1);
        buttonPanel.Name = "buttonPanel";
        buttonPanel.Size = new Size(180, 509);
        buttonPanel.TabIndex = 1;
        // 
        // bookReservation
        // 
        bookReservation.AutoEllipsis = true;
        bookReservation.FlatAppearance.BorderSize = 0;
        bookReservation.FlatStyle = FlatStyle.Flat;
        bookReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        bookReservation.ForeColor = Color.White;
        bookReservation.Location = new Point(9, 92);
        bookReservation.Margin = new Padding(2, 1, 2, 1);
        bookReservation.Name = "bookReservation";
        bookReservation.Size = new Size(168, 46);
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
        logOutButton.Location = new Point(20, 448);
        logOutButton.Margin = new Padding(2, 1, 2, 1);
        logOutButton.Name = "logOutButton";
        logOutButton.Size = new Size(146, 40);
        logOutButton.TabIndex = 2;
        logOutButton.Text = "LogOut";
        logOutButton.UseVisualStyleBackColor = true;
        // 
        // multiSelectComboBox1
        // 
        multiSelectComboBox1.Location = new Point(22, 305);
        multiSelectComboBox1.Name = "multiSelectComboBox1";
        multiSelectComboBox1.Size = new Size(138, 26);
        multiSelectComboBox1.TabIndex = 5;
        multiSelectComboBox1.Load += multiSelectComboBox1_Load;
        // 
        // DashboardForm
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(840, 509);
        Controls.Add(contentPanel);
        Controls.Add(buttonPanel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(2, 1, 2, 1);
        MaximizeBox = false;
        Name = "DashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Library Dashboard";
        buttonPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
    private Panel buttonPanel;
    private Button logOutButton;
    private Button bookReservation;
    private Component.DropdownControl dropdownControl1;
    private MultiSelectComboBox multiSelectComboBox1;
}
