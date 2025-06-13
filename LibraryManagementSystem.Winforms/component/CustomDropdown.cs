using LibraryManagementSystem.Winforms.helpers;
using System.ComponentModel;

namespace LibraryManagementSystem.Winforms.component
{
    public partial class CustomDropdown : UserControl
    {
        public event EventHandler SelectedIndexChanged;

        public CustomDropdown()
        {
            InitializeComponent();

            // Forward internal ComboBox event to external consumer
            comboBox.SelectedIndexChanged += (s, e) => SelectedIndexChanged?.Invoke(this, e);

            if (!DesignMode)
            {
                SetOptions(new List<DropDownOption>
                {
                    new DropDownOption { Label = "Option A", Value = "A" },
                    new DropDownOption { Label = "Option B", Value = "B" }
                });
            }
        }

        public void SetOptions(List<DropDownOption> options)
        {
            if (!DesignMode)
            {
                // Unsubscribe temporarily to avoid event firing during setup
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

                comboBox.DataSource = null;
                comboBox.DisplayMember = "Label";
                comboBox.ValueMember = "Value";
                comboBox.DataSource = options;
                comboBox.SelectedIndex = -1;

                // Re-subscribe after setting
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        // Optional: backup handler (not required if you use the lambda above)
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged?.Invoke(this, e);
        }

        [Browsable(false)]
        public object SelectedValue => comboBox.SelectedValue;

        [Browsable(false)]
        public DropDownOption SelectedOption => comboBox.SelectedItem as DropDownOption;
    }
}
