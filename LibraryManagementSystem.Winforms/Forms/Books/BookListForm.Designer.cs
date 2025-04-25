namespace LibraryManagementSystem.Winforms.Forms.Books
{
    partial class BookListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            dataGridViewBooks = new DataGridView();
            bookSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            authorSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            multiSelectComboBox3 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeight = 46;
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(0, 0);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new Size(1462, 1163);
            dataGridViewBooks.TabIndex = 1;
            // 
            // bookSelectComboBox
            // 
            bookSelectComboBox.LabelText = "Select Books:";
            bookSelectComboBox.Location = new Point(81, 34);
            bookSelectComboBox.Name = "bookSelectComboBox";
            bookSelectComboBox.Size = new Size(334, 50);
            bookSelectComboBox.TabIndex = 2;
            // 
            // authorSelectComboBox
            // 
            authorSelectComboBox.LabelText = "Select Author:";
            authorSelectComboBox.Location = new Point(452, 34);
            authorSelectComboBox.Name = "authorSelectComboBox";
            authorSelectComboBox.Size = new Size(320, 50);
            authorSelectComboBox.TabIndex = 3;
            // 
            // multiSelectComboBox3
            // 
            multiSelectComboBox3.LabelText = "Select...";
            multiSelectComboBox3.Location = new Point(836, 34);
            multiSelectComboBox3.Name = "multiSelectComboBox3";
            multiSelectComboBox3.Size = new Size(282, 50);
            multiSelectComboBox3.TabIndex = 4;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 1163);
            Controls.Add(multiSelectComboBox3);
            Controls.Add(authorSelectComboBox);
            Controls.Add(bookSelectComboBox);
            Controls.Add(dataGridViewBooks);
            Margin = new Padding(6);
            Name = "BookListForm";
            Text = "Book List";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewBooks;

        #endregion

        private Component.MultiSelectComboBox bookSelectComboBox;
        private Component.MultiSelectComboBox authorSelectComboBox;
        private Component.MultiSelectComboBox multiSelectComboBox3;
    }
}