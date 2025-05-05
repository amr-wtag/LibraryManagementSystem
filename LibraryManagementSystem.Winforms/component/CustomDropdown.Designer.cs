namespace LibraryManagementSystem.Winforms.component
{
    partial class CustomDropdown
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBox = new ComboBox();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.Dock = DockStyle.Fill;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(0, 0);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(200, 23);
            comboBox.TabIndex = 0;
            // 
            // CustomDropdown
            // 
            Controls.Add(comboBox);
            Name = "CustomDropdown";
            Size = new Size(200, 21);
            ResumeLayout(false);
        }
    }
}
