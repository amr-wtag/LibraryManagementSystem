namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    partial class AddReservationForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            userDropdownControl = new LibraryManagementSystem.Winforms.component.CustomDropdown();
            userLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            bookReservation = new LibraryManagementSystem.Winforms.Forms.BookReservation.BookReservationRow.BookReservationRowControl();
            submitButton = new Button();
            bookReservationDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            issuedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookReservationDisplayModalBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookReservationDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookReservationDisplayModalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(submitButton, 0, 4);
            tableLayoutPanel1.Controls.Add(bookReservationDataGridView, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1421, 996);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1413, 49);
            label1.TabIndex = 0;
            label1.Text = "Add Reservation Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.7417641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.2582359F));
            tableLayoutPanel2.Controls.Add(userDropdownControl, 1, 0);
            tableLayoutPanel2.Controls.Add(userLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 55);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1409, 54);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // userDropdownControl
            // 
            userDropdownControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            userDropdownControl.Location = new Point(620, 2);
            userDropdownControl.Margin = new Padding(4, 2, 4, 2);
            userDropdownControl.Name = "userDropdownControl";
            userDropdownControl.Size = new Size(260, 50);
            userDropdownControl.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.Right;
            userLabel.AutoSize = true;
            userLabel.BackColor = SystemColors.Control;
            userLabel.Location = new Point(550, 11);
            userLabel.Margin = new Padding(0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(66, 32);
            userLabel.TabIndex = 2;
            userLabel.Text = "User:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.768856F));
            tableLayoutPanel3.Controls.Add(bookReservation, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 121);
            tableLayoutPanel3.Margin = new Padding(6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1409, 116);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // bookReservation
            // 
            bookReservation.AutoSize = true;
            bookReservation.Dock = DockStyle.Fill;
            bookReservation.Location = new Point(4, 2);
            bookReservation.Margin = new Padding(4, 2, 4, 2);
            bookReservation.Name = "bookReservation";
            bookReservation.Size = new Size(1401, 112);
            bookReservation.TabIndex = 0;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            submitButton.Location = new Point(611, 922);
            submitButton.Margin = new Padding(6);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(199, 68);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit Button";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // bookReservationDataGridView
            // 
            bookReservationDataGridView.AllowUserToAddRows = false;
            bookReservationDataGridView.AllowUserToDeleteRows = false;
            bookReservationDataGridView.AutoGenerateColumns = false;
            bookReservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookReservationDataGridView.ColumnHeadersHeight = 46;
            bookReservationDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, bookTitleDataGridViewTextBoxColumn, issuedDateDataGridViewTextBoxColumn, dueDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            bookReservationDataGridView.DataSource = bookReservationDisplayModalBindingSource;
            bookReservationDataGridView.Dock = DockStyle.Fill;
            bookReservationDataGridView.Location = new Point(3, 246);
            bookReservationDataGridView.Name = "bookReservationDataGridView";
            bookReservationDataGridView.ReadOnly = true;
            bookReservationDataGridView.RowHeadersVisible = false;
            bookReservationDataGridView.RowHeadersWidth = 82;
            bookReservationDataGridView.Size = new Size(1415, 667);
            bookReservationDataGridView.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 10;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            bookTitleDataGridViewTextBoxColumn.MinimumWidth = 10;
            bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            bookTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuedDateDataGridViewTextBoxColumn
            // 
            issuedDateDataGridViewTextBoxColumn.DataPropertyName = "IssuedDate";
            issuedDateDataGridViewTextBoxColumn.HeaderText = "IssuedDate";
            issuedDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            issuedDateDataGridViewTextBoxColumn.Name = "issuedDateDataGridViewTextBoxColumn";
            issuedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookReservationDisplayModalBindingSource
            // 
            bookReservationDisplayModalBindingSource.DataSource = typeof(Models.BookReservations.BookReservationDisplayModal);
            // 
            // AddReservationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 996);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "AddReservationForm";
            Text = "AddReservationForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookReservationDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookReservationDisplayModalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private component.CustomDropdown userDropdownControl;
        private TableLayoutPanel tableLayoutPanel2;
        private Label userLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button submitButton;
        private BookReservationRow.BookReservationRowControl bookReservation;
        private DataGridView bookReservationDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn issuedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource bookReservationDisplayModalBindingSource;
    }
}
