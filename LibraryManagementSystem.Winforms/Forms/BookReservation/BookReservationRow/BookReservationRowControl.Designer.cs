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
            removeButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bookDropdown
            // 
            bookDropdown.Location = new Point(12, 12);
            bookDropdown.Margin = new Padding(12);
            bookDropdown.Name = "bookDropdown";
            bookDropdown.Size = new Size(314, 44);
            bookDropdown.TabIndex = 0;
            // 
            // issueDateTimePicker
            // 
            issueDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            issueDateTimePicker.Location = new Point(350, 12);
            issueDateTimePicker.Margin = new Padding(12);
            issueDateTimePicker.Name = "issueDateTimePicker";
            issueDateTimePicker.Size = new Size(400, 39);
            issueDateTimePicker.TabIndex = 1;
            issueDateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(774, 12);
            removeButton.Margin = new Padding(12);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(150, 44);
            removeButton.TabIndex = 2;
            removeButton.Text = "X Remove";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(bookDropdown, 0, 0);
            tableLayoutPanel1.Controls.Add(removeButton, 2, 0);
            tableLayoutPanel1.Controls.Add(issueDateTimePicker, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(934, 68);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // BookReservationRowControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "BookReservationRowControl";
            Size = new Size(940, 76);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private component.CustomDropdown bookDropdown;
        private DateTimePicker issueDateTimePicker;
        private Button removeButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
