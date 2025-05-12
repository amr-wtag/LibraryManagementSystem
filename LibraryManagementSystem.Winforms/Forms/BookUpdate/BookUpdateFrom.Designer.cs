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
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(updateBookHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1456, 1042);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // updateBookHeader
            // 
            updateBookHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            updateBookHeader.AutoSize = true;
            updateBookHeader.Location = new Point(652, 0);
            updateBookHeader.Name = "updateBookHeader";
            updateBookHeader.Size = new Size(152, 50);
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
            tableLayoutPanel2.Location = new Point(3, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Size = new Size(1450, 64);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // bookTItle
            // 
            bookTItle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bookTItle.AutoSize = true;
            bookTItle.Location = new Point(70, 12);
            bookTItle.Margin = new Padding(8, 12, 8, 8);
            bookTItle.Name = "bookTItle";
            bookTItle.Size = new Size(126, 50);
            bookTItle.TabIndex = 0;
            bookTItle.Text = "Book TItle:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(266, 0);
            textBox1.Margin = new Padding(0);
            textBox1.MinimumSize = new Size(70, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1184, 39);
            textBox1.TabIndex = 1;
            // 
            // BookUpdateFrom
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 1042);
            Controls.Add(tableLayoutPanel1);
            Name = "BookUpdateFrom";
            Text = "BookUpdateFrom";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label updateBookHeader;
        private TableLayoutPanel tableLayoutPanel2;
        private Label bookTItle;
        private TextBox textBox1;
    }
}