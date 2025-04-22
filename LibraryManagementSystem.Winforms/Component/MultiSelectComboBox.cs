using LibraryManagementSystem.Winforms.helpers;

namespace LibraryManagementSystem.Winforms.Component
{
    public partial class MultiSelectComboBox : UserControl
    {
        public event EventHandler? SelectedValuesChanged;
        private Label titleLabel;
        private string _labelText = "Select...";

        public MultiSelectComboBox()
        {
            InitializeComponent();
            SetupDropDown();
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            var location = this.PointToScreen(new System.Drawing.Point(0, this.Height));
            dropDown.Show(location);
        }

        private void SetupDropDown()
        {
            var host = new ToolStripControlHost(checkedListBox)
            {
                AutoSize = false,
                Size = new System.Drawing.Size(200, 120)
            };

            dropDown.Items.Add(host);
            dropDown.Closing += (s, e) => UpdateText();

            checkedListBox.CheckOnClick = true;
            checkedListBox.ItemCheck += (s, e) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    UpdateText();
                    SelectedValuesChanged?.Invoke(this, EventArgs.Empty);
                }));
            };
        }

        public void SetItems(IEnumerable<DropDownOption> options)
        {
            checkedListBox.Items.Clear();
            foreach (var item in options)
            {
                checkedListBox.Items.Add(item);
            }
            UpdateText();
        }

        public List<DropDownOption> GetSelectedItems()
        {
            return checkedListBox.CheckedItems.Cast<DropDownOption>().ToList();
        }

        private void UpdateText()
        {
            var selected = GetSelectedItems();
            displayBox.Text = selected.Any()
                ? string.Join(", ", selected.Select(i => i.Label))
                : "Select...";
        }

        public string LabelText
        {
            get => _labelText;
            set
            {
                _labelText = value;
                titleLabel.Text = value;
            }
        }
    }
}
