using LibraryManagementSystem.Winforms.Forms.Books;
using LibraryManagementSystem.Winforms.Forms.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibraryManagementSystem.Winforms.Forms.Dashboard;

public partial class DashboardForm : Form
{

    private Panel contentPanel;
    private Button booksButton;
    private Button usersButton;
    public DashboardForm()
    {
        InitializeComponent();
        InitializeDashboard();
        // Load += DashboardForm_Load;
    }

    public void InitializeDashboard()
    {
        this.Text = "Library Dashboard";
        this.Size = new Size(800, 600);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;

        Panel buttonPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 60,
            BackColor = Color.FromArgb(44, 62, 80)
        };
        booksButton = new Button
        {
            Text = "📚 Books",
            FlatStyle = FlatStyle.Flat,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
            Size = new Size(150, 40),
            Location = new Point(20, 10)
        };
        booksButton.FlatAppearance.BorderSize = 0;
        booksButton.Click += BooksButton_Click;


        usersButton = new Button
        {
            Text = "👤 Users",
            FlatStyle = FlatStyle.Flat,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
            Size = new Size(150, 40),
            Location = new Point(190, 10)
        };
        usersButton.FlatAppearance.BorderSize = 0;
        usersButton.Click += UsersButton_Click;

        buttonPanel.Controls.Add(booksButton);
        buttonPanel.Controls.Add(usersButton);

        contentPanel = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.White
        };

        this.Controls.Add(contentPanel);
        this.Controls.Add(buttonPanel);


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
}