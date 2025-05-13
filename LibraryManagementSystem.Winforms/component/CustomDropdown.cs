using LibraryManagementSystem.Winforms.helpers;

namespace LibraryManagementSystem.Winforms.component
{
    public partial class CustomDropdown : UserControl
    {
        // Constructor
        public CustomDropdown()
        {
            InitializeComponent();

            // Check if we're in design mode
            if (!DesignMode)
            {
                SetOptions(new List<DropDownOption>
                {
                    new DropDownOption { Label = "Option A", Value = "A" },
                    new DropDownOption { Label = "Option B", Value = "B" }
                });
            }
        }

        // Method to set options for the dropdown
        public void SetOptions(List<DropDownOption> options)
        {
            if (!DesignMode) // Ensures we don't bind data during design time
            {
                comboBox.DataSource = options;
                comboBox.DisplayMember = "Label"; // Property to display in the dropdown
                comboBox.ValueMember = "Value"; // Property to use for the value
                comboBox.SelectedIndex = -1;
            }
        }

        // Property to get the selected value from the dropdown
        public object SelectedValue => comboBox.SelectedValue;

        // Property to get the selected option (as a DropDownOption object)
        public DropDownOption SelectedOption => comboBox.SelectedItem as DropDownOption;
    }
}
