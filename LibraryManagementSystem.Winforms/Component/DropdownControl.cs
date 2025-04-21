using System;
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

        public DropdownControl(bool isMultiSelect = false)
        {
            IsMultiSelect = isMultiSelect;
            InitializeControls();
        }

        private void InitializeControls()
        {
            singleSelectComboBox = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            multiSelectListBox = new CheckedListBox
            {
                Dock = DockStyle.Fill,
                CheckOnClick = true,
                Visible = false
            };

            Controls.Add(singleSelectComboBox);
            Controls.Add(multiSelectListBox);
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
            }
            else
            {
                singleSelectComboBox.Visible = true;
                multiSelectListBox.Visible = false;

                singleSelectComboBox.DataSource = null;
                singleSelectComboBox.DataSource = options;
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
