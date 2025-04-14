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
            lblHeader = new System.Windows.Forms.Label();
            dataGridViewBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblHeader.Location = new System.Drawing.Point(56, 43);
            lblHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(363, 51);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book List (Loading...)";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dataGridViewBooks.ColumnHeadersHeight = 46;
            dataGridViewBooks.Location = new System.Drawing.Point(30, 119);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new System.Drawing.Size(1148, 859);
            dataGridViewBooks.TabIndex = 1;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1210, 1013);
            Controls.Add(dataGridViewBooks);
            Controls.Add(lblHeader);
            Margin = new System.Windows.Forms.Padding(6);
            Text = "Book List";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewBooks;

        #endregion

        private System.Windows.Forms.Label lblHeader;
    }
}