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
            authorSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            authorsLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            genreLabel = new Label();
            genreSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            bookCountLabel = new Label();
            booksAvailableTextBox = new TextBox();
            buttonLayout = new TableLayoutPanel();
            submitButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            buttonLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(updateBookHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonLayout, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(1456, 1041);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // updateBookHeader
            // 
            updateBookHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            updateBookHeader.AutoSize = true;
            updateBookHeader.Location = new Point(652, 0);
            updateBookHeader.Margin = new Padding(4, 0, 4, 0);
            updateBookHeader.Name = "updateBookHeader";
            updateBookHeader.Size = new Size(152, 49);
            updateBookHeader.TabIndex = 0;
            updateBookHeader.Text = "Update Book";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(bookTItle, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 51);
            tableLayoutPanel2.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Size = new Size(1448, 69);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // bookTItle
            // 
            bookTItle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bookTItle.AutoSize = true;
            bookTItle.Location = new Point(30, 13);
            bookTItle.Margin = new Padding(7, 13, 7, 9);
            bookTItle.Name = "bookTItle";
            bookTItle.Size = new Size(126, 48);
            bookTItle.TabIndex = 0;
            bookTItle.Text = "Book TItle:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(192, 11);
            textBox1.Margin = new Padding(6, 11, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1250, 39);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1259F));
            tableLayoutPanel3.Controls.Add(authorSelectComboBox, 1, 0);
            tableLayoutPanel3.Controls.Add(authorsLabel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 128);
            tableLayoutPanel3.Margin = new Padding(6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1444, 61);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // authorSelectComboBox
            // 
            authorSelectComboBox.LabelText = "";
            authorSelectComboBox.Location = new Point(192, 6);
            authorSelectComboBox.Margin = new Padding(6);
            authorSelectComboBox.Name = "authorSelectComboBox";
            authorSelectComboBox.Size = new Size(708, 47);
            authorSelectComboBox.TabIndex = 1;
            // 
            // authorsLabel
            // 
            authorsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            authorsLabel.AutoSize = true;
            authorsLabel.Location = new Point(42, 13);
            authorsLabel.Margin = new Padding(7, 13, 7, 9);
            authorsLabel.MaximumSize = new Size(117, 49);
            authorsLabel.Name = "authorsLabel";
            authorsLabel.Size = new Size(102, 39);
            authorsLabel.TabIndex = 0;
            authorsLabel.Text = "Authors:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1259F));
            tableLayoutPanel4.Controls.Add(genreLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(genreSelectComboBox, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(6, 201);
            tableLayoutPanel4.Margin = new Padding(6);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1444, 61);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // genreLabel
            // 
            genreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(46, 13);
            genreLabel.Margin = new Padding(7, 13, 7, 9);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(93, 39);
            genreLabel.TabIndex = 0;
            genreLabel.Text = "Genres:";
            // 
            // genreSelectComboBox
            // 
            genreSelectComboBox.LabelText = "";
            genreSelectComboBox.Location = new Point(192, 6);
            genreSelectComboBox.Margin = new Padding(6);
            genreSelectComboBox.Name = "genreSelectComboBox";
            genreSelectComboBox.Size = new Size(708, 47);
            genreSelectComboBox.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1216F));
            tableLayoutPanel5.Controls.Add(bookCountLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(booksAvailableTextBox, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(6, 274);
            tableLayoutPanel5.Margin = new Padding(6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1444, 61);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // bookCountLabel
            // 
            bookCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bookCountLabel.AutoSize = true;
            bookCountLabel.Location = new Point(41, 13);
            bookCountLabel.Margin = new Padding(7, 13, 7, 9);
            bookCountLabel.Name = "bookCountLabel";
            bookCountLabel.Size = new Size(145, 39);
            bookCountLabel.TabIndex = 0;
            bookCountLabel.Text = "Book Count:";
            // 
            // booksAvailableTextBox
            // 
            booksAvailableTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            booksAvailableTextBox.Location = new Point(234, 6);
            booksAvailableTextBox.Margin = new Padding(6);
            booksAvailableTextBox.Name = "booksAvailableTextBox";
            booksAvailableTextBox.Size = new Size(290, 39);
            booksAvailableTextBox.TabIndex = 1;
            // 
            // buttonLayout
            // 
            buttonLayout.ColumnCount = 2;
            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonLayout.Controls.Add(submitButton, 0, 0);
            buttonLayout.Controls.Add(cancelButton, 1, 0);
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(3, 344);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.RowCount = 1;
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonLayout.Size = new Size(1450, 93);
            buttonLayout.TabIndex = 5;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            submitButton.Location = new Point(125, 3);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(150, 87);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.Location = new Point(403, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 87);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // BookUpdateFrom
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 1041);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BookUpdateFrom";
            Text = "BookUpdateFrom";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            buttonLayout.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel4;
        private Label genreLabel;
        private Component.MultiSelectComboBox genreSelectComboBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label bookCountLabel;
        private TextBox booksAvailableTextBox;
        private TableLayoutPanel buttonLayout;
        private Button submitButton;
        private Button cancelButton;
    }
}
