namespace LibraryManagementSystem.Winforms.Component
{
    partial class MultiSelectComboBox
    {
        private TextBox displayBox;
        private Button dropButton;
        private CheckedListBox checkedListBox;
        private ToolStripDropDown dropDown;

        private void InitializeComponent()
        {
            displayBox = new TextBox();
            dropButton = new Button();
            checkedListBox = new CheckedListBox();
            dropDown = new ToolStripDropDown();
            SuspendLayout();
            // 
            // displayBox
            // 
            displayBox.Dock = DockStyle.Fill;
            displayBox.Location = new Point(0, 0);
            displayBox.Name = "displayBox";
            displayBox.ReadOnly = true;
            displayBox.Size = new Size(198, 39);
            displayBox.TabIndex = 1;
            // 
            // dropButton
            // 
            dropButton.Dock = DockStyle.Right;
            dropButton.ForeColor = Color.CornflowerBlue;
            dropButton.Location = new Point(198, 0);
            dropButton.Name = "dropButton";
            dropButton.Size = new Size(20, 37);
            dropButton.TabIndex = 2;
            dropButton.Text = "▼";
            dropButton.Click += DropButton_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.Dock = DockStyle.Fill;
            checkedListBox.Location = new Point(0, 0);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(120, 96);
            checkedListBox.TabIndex = 0;
            // 
            // dropDown
            // 
            dropDown.ImageScalingSize = new Size(32, 32);
            dropDown.LayoutStyle = ToolStripLayoutStyle.Flow;
            dropDown.Name = "dropDown";
            dropDown.Size = new Size(4, 8);
            // 
            // MultiSelectComboBox
            // 
            Controls.Add(displayBox);
            Controls.Add(dropButton);
            Name = "MultiSelectComboBox";
            Size = new Size(218, 37);
            ResumeLayout(false);
            PerformLayout();
        }
    }

}
