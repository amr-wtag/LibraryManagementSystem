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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(0, 0);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(200, 21);
            this.comboBox.TabIndex = 0;
            // 
            // CustomDropdown
            // 
            this.Controls.Add(this.comboBox);
            this.Name = "CustomDropdown";
            this.Size = new System.Drawing.Size(200, 21);
            this.ResumeLayout(false);
        }
    }
}
