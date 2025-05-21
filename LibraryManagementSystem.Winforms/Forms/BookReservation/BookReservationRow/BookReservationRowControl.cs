using LibraryManagementSystem.Winforms.dataHelpers;

namespace LibraryManagementSystem.Winforms.Forms.BookReservation.BookReservationRow
{
    public partial class BookReservationRowControl : UserControl
    {
        public event EventHandler RemoveClicked;

        public BookReservationRowControl()
        {
            InitializeComponent();
            removeButton.Click += RemoveButton_Click;

            // Subscribe to the Load event
            this.Load += BookReservationRowControl_Load;
        }

        private async void BookReservationRowControl_Load(object sender, EventArgs e)
        {
            // Call SetBookOptions when the control is loaded
            await SetBookOptions();
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
        public async Task SetBookOptions()
        {
            // Fetch the book options asynchronously
            var options = await BookDropdownHelper.LoadBookOptionsAsync();

            if (options.Any())
            {
                // Set the options in the dropdown
                bookDropdown.SetOptions(options);
            }
            else
            {
                // Handle the case when no options are available (optional)
                MessageBox.Show("No book options available.");
            }
        }
    }
}
