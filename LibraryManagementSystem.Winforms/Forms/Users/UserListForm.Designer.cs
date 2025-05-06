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
            components = new System.ComponentModel.Container();
            DataGridViewUsers = new DataGridView();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            userBindingSource1 = new BindingSource(components);
            userBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewUsers
            // 
            DataGridViewUsers.AutoGenerateColumns = false;
            DataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { fullNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            DataGridViewUsers.DataSource = userBindingSource;
            DataGridViewUsers.Dock = DockStyle.Fill;
            DataGridViewUsers.Location = new Point(0, 0);
            DataGridViewUsers.Margin = new Padding(2, 1, 2, 1);
            DataGridViewUsers.Name = "DataGridViewUsers";
            DataGridViewUsers.RowHeadersVisible = false;
            DataGridViewUsers.RowHeadersWidth = 82;
            DataGridViewUsers.Size = new Size(776, 433);
            DataGridViewUsers.TabIndex = 0;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.Users.User);
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(Models.Users.User);
            // 
            // userBindingSource2
            // 
            userBindingSource2.DataSource = typeof(Models.Users.User);
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 433);
            Controls.Add(DataGridViewUsers);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UserListForm";
            Text = "Form1";
            Load += UserListForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewUsers;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
        private BindingSource userBindingSource2;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}
