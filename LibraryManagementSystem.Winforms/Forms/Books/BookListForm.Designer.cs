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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 46;
            dataGridView1.Location = new System.Drawing.Point(26, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new System.Drawing.Size(1060, 691);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeight = 46;
            dataGridView2.Location = new System.Drawing.Point(27, 81);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new System.Drawing.Size(1060, 691);
            dataGridView2.TabIndex = 2;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1114, 853);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(lblHeader);
            Margin = new System.Windows.Forms.Padding(6);
            Text = "Book List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView2;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion

        private System.Windows.Forms.Label lblHeader;
    }
}