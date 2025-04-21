using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystem.Winforms.helpers;

namespace LibraryManagementSystem.Winforms.Component
{
    public partial class DropdownControl : UserControl
    {

        public bool IsMultiSelect { get; set; }

        // Required for designer
        public DropdownControl() : this(false) { }

        // Main constructor
        public DropdownControl(bool isMultiSelect)
        {
            IsMultiSelect = isMultiSelect;

            InitializeComponent(); // REQUIRED for design view
            InitializeControls();
        }

        private void InitializeControls()
        {
            singleSelectComboBox.Visible = !IsMultiSelect;
            multiSelectListBox.Visible = IsMultiSelect;

            if (DesignMode)
            {
                singleSelectComboBox.Items.Add("Option A");
                singleSelectComboBox.Items.Add("Option B");
                singleSelectComboBox.SelectedIndex = 0;
            }
        }

        public void SetOptions(List<DropDownOption> options)
        {
            if (IsMultiSelect)
            {
                multiSelectListBox.Visible = true;
                singleSelectComboBox.Visible = false;

                multiSelectListBox.Items.Clear();
                foreach (var item in options)
                    multiSelectListBox.Items.Add(item);

                // Dynamic height based on item count
                int itemHeight = multiSelectListBox.ItemHeight;
                int itemCount = options.Count;
                int maxVisibleItems = 8; // Limit how tall the list can grow
                int visibleItemCount = Math.Min(itemCount, maxVisibleItems);

                int desiredHeight = (itemHeight * visibleItemCount) + 4; // 4px for padding/margin
                multiSelectListBox.Height = desiredHeight;

                // 👇 Set the overall control height to match the list height
                this.Size = new Size(this.Width, desiredHeight);
            }
            else
            {
                singleSelectComboBox.Visible = true;
                multiSelectListBox.Visible = false;

                singleSelectComboBox.DataSource = null;
                singleSelectComboBox.DataSource = options;

                // Optional: Fix height for single-select mode
                this.Size = new Size(this.Width, singleSelectComboBox.Height);
            }
        }


        public DropDownOption GetSelectedItem()
        {
            if (IsMultiSelect) return null;
            return singleSelectComboBox.SelectedItem as DropDownOption;
        }

        public List<DropDownOption> GetSelectedItems()
        {
            if (!IsMultiSelect) return null;

            return multiSelectListBox.CheckedItems
                .OfType<DropDownOption>()
                .ToList();
        }
    }
}
