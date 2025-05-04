//namespace LibraryManagementSystem.Winforms.Forms.BookReservation.BookReservationRow
//{
//    public partial class BookReservationRowControl : UserControl
//    {

//        public event EventHandler RemoveClicked;
//        public BookReservationRowControl()
//        {
//            InitializeComponent();
//        }

//        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
using LibraryManagementSystem.Winforms.helpers;

namespace LibraryManagementSystem.Winforms.Forms.BookReservation.BookReservationRow
{
    public partial class BookReservationRowControl : UserControl
    {
        public event EventHandler RemoveClicked;

        public BookReservationRowControl()
        {
            InitializeComponent();
            removeButton.Click += RemoveButton_Click;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }

        // Optional: Handle date change if needed
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Logic if required on date change
        }

        // Get the selected book ID from the custom dropdown
        public string SelectedBookId => bookDropdown.SelectedOption?.Value?.ToString();

        // Get the selected due date
        public DateTime DueDate => issueDateTimePicker.Value;

        // Set the available book options in the dropdown
        public void SetBookOptions(List<DropDownOption> bookOptions)
        {
            bookDropdown.SetOptions(bookOptions);
        }
    }
}
