namespace LibraryManagementSystem.Winforms.Forms.Users
{
    partial class UserListForm
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
            DataGridViewUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewUsers
            // 
            DataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUsers.Location = new Point(39, 38);
            DataGridViewUsers.Name = "DataGridViewUsers";
            DataGridViewUsers.RowHeadersWidth = 82;
            DataGridViewUsers.Size = new Size(1354, 840);
            DataGridViewUsers.TabIndex = 0;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 924);
            Controls.Add(DataGridViewUsers);
            Name = "UserListForm";
            Text = "Form1";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewUsers;
    }
}