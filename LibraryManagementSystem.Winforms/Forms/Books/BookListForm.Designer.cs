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
            multiSelectComboBox1 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            multiSelectComboBox2 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            multiSelectComboBox3 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBooks.ColumnHeadersHeight = 46;
            dataGridViewBooks.Location = new Point(30, 119);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new Size(1148, 859);
            dataGridViewBooks.TabIndex = 1;
            // 
            // multiSelectComboBox1
            // 
            multiSelectComboBox1.Location = new Point(53, 46);
            multiSelectComboBox1.Name = "multiSelectComboBox1";
            multiSelectComboBox1.Size = new Size(254, 50);
            multiSelectComboBox1.TabIndex = 2;
            multiSelectComboBox1.Load += multiSelectComboBox1_Load;
            // 
            // multiSelectComboBox2
            // 
            multiSelectComboBox2.Location = new Point(368, 46);
            multiSelectComboBox2.Name = "multiSelectComboBox2";
            multiSelectComboBox2.Size = new Size(254, 50);
            multiSelectComboBox2.TabIndex = 3;
            // 
            // multiSelectComboBox3
            // 
            multiSelectComboBox3.Location = new Point(686, 46);
            multiSelectComboBox3.Name = "multiSelectComboBox3";
            multiSelectComboBox3.Size = new Size(254, 50);
            multiSelectComboBox3.TabIndex = 4;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 1013);
            Controls.Add(multiSelectComboBox3);
            Controls.Add(multiSelectComboBox2);
            Controls.Add(multiSelectComboBox1);
            Controls.Add(dataGridViewBooks);
            Margin = new Padding(6);
            Name = "BookListForm";
            Text = "Book List";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewBooks;

        #endregion

        private Component.MultiSelectComboBox multiSelectComboBox1;
        private Component.MultiSelectComboBox multiSelectComboBox2;
        private Component.MultiSelectComboBox multiSelectComboBox3;
    }
}