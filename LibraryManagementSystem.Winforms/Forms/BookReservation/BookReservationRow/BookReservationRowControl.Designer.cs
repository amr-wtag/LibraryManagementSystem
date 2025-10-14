namespace LibraryManagementSystem.Winforms.Forms.BookReservation.BookReservationRow
{
    partial class BookReservationRowControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            bookDropdown = new LibraryManagementSystem.Winforms.component.CustomDropdown();
            issueDateTimePicker = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            dueDateLabel = new Label();
            bookLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bookDropdown
            // 
            bookDropdown.Dock = DockStyle.Fill;
            bookDropdown.Location = new Point(11, 53);
            bookDropdown.Margin = new Padding(11, 21, 11, 13);
            bookDropdown.Name = "bookDropdown";
            bookDropdown.Size = new Size(314, 54);
            bookDropdown.TabIndex = 0;
            // 
            // issueDateTimePicker
            // 
            issueDateTimePicker.Dock = DockStyle.Fill;
            issueDateTimePicker.Location = new Point(347, 53);
            issueDateTimePicker.Margin = new Padding(11, 21, 11, 13);
            issueDateTimePicker.Name = "issueDateTimePicker";
            issueDateTimePicker.Size = new Size(593, 39);
            issueDateTimePicker.TabIndex = 1;
            issueDateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dueDateLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(bookDropdown, 0, 1);
            tableLayoutPanel1.Controls.Add(issueDateTimePicker, 1, 1);
            tableLayoutPanel1.Controls.Add(bookLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.MinimumSize = new Size(0, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(951, 120);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Dock = DockStyle.Fill;
            dueDateLabel.Location = new Point(339, 0);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(609, 32);
            dueDateLabel.TabIndex = 3;
            dueDateLabel.Text = "DueDateLabel";
            // 
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.Dock = DockStyle.Fill;
            bookLabel.Location = new Point(3, 0);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(330, 32);
            bookLabel.TabIndex = 2;
            bookLabel.Text = "BookLabel";
            // 
            // BookReservationRowControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BookReservationRowControl";
            Size = new Size(951, 120);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private component.CustomDropdown bookDropdown;
        private DateTimePicker issueDateTimePicker;
        private TableLayoutPanel tableLayoutPanel1;
        private Label dueDateLabel;
        private Label bookLabel;
    }
}
