using LibraryManagementSystem.Winforms.Forms.Books;
using LibraryManagementSystem.Winforms.Forms.Users;

namespace LibraryManagementSystem.Winforms.Forms.Dashboard;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
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
