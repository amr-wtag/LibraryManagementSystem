namespace LibraryManagementSystem.Winforms.Forms.BookUpdate
{
    partial class BookUpdateFrom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            updateBookHeader = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            bookTItle = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            authorsLabel = new Label();
            authorSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(updateBookHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(784, 488);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // updateBookHeader
            // 
            updateBookHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            updateBookHeader.AutoSize = true;
            updateBookHeader.Location = new Point(354, 0);
            updateBookHeader.Margin = new Padding(2, 0, 2, 0);
            updateBookHeader.Name = "updateBookHeader";
            updateBookHeader.Size = new Size(75, 23);
            updateBookHeader.TabIndex = 0;
            updateBookHeader.Text = "Update Book";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.41379F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.58621F));
            tableLayoutPanel2.Controls.Add(bookTItle, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 24);
            tableLayoutPanel2.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Size = new Size(780, 32);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // bookTItle
            // 
            bookTItle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bookTItle.AutoSize = true;
            bookTItle.Location = new Point(40, 6);
            bookTItle.Margin = new Padding(4, 6, 4, 4);
            bookTItle.Name = "bookTItle";
            bookTItle.Size = new Size(63, 23);
            bookTItle.TabIndex = 0;
            bookTItle.Text = "Book TItle:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(146, 5);
            textBox1.Margin = new Padding(3, 5, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(631, 23);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2519283F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.74807F));
            tableLayoutPanel3.Controls.Add(authorsLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(authorSelectComboBox, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 60);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(778, 28);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // authorsLabel
            // 
            authorsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            authorsLabel.AutoSize = true;
            authorsLabel.Location = new Point(45, 0);
            authorsLabel.Name = "authorsLabel";
            authorsLabel.Size = new Size(52, 28);
            authorsLabel.TabIndex = 0;
            authorsLabel.Text = "Authors:";
            // 
            // authorSelectComboBox
            // 
            authorSelectComboBox.LabelText = "";
            authorSelectComboBox.Location = new Point(145, 3);
            authorSelectComboBox.Name = "authorSelectComboBox";
            authorSelectComboBox.Size = new Size(630, 22);
            authorSelectComboBox.TabIndex = 1;
            // 
            // BookUpdateFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 488);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "BookUpdateFrom";
            Text = "BookUpdateFrom";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label updateBookHeader;
        private TableLayoutPanel tableLayoutPanel2;
        private Label bookTItle;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label authorsLabel;
        private Component.MultiSelectComboBox authorSelectComboBox;
    }
}
