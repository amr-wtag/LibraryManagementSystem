namespace LibraryManagementSystem.Winforms.Component
{
    partial class DropdownControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox singleSelectComboBox;
        private System.Windows.Forms.CheckedListBox multiSelectListBox;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            singleSelectComboBox = new ComboBox();
            multiSelectListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // singleSelectComboBox
            // 
            singleSelectComboBox.Dock = DockStyle.Fill;
            singleSelectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            singleSelectComboBox.FormattingEnabled = true;
            singleSelectComboBox.Location = new Point(0, 0);
            singleSelectComboBox.Name = "singleSelectComboBox";
            singleSelectComboBox.Size = new Size(200, 23);
            singleSelectComboBox.TabIndex = 0;
            // 
            // multiSelectListBox
            // 
            multiSelectListBox.CheckOnClick = true;
            multiSelectListBox.Dock = DockStyle.Fill;
            multiSelectListBox.FormattingEnabled = true;
            multiSelectListBox.Location = new Point(0, 0);
            multiSelectListBox.Name = "multiSelectListBox";
            multiSelectListBox.Size = new Size(200, 100);
            multiSelectListBox.TabIndex = 1;
            multiSelectListBox.Visible = false;
            // 
            // DropdownControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(singleSelectComboBox);
            Controls.Add(multiSelectListBox);
            Name = "DropdownControl";
            Size = new Size(200, 100);
            ResumeLayout(false);
        }

        #endregion
    }
}