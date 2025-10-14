namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    partial class BookReservationForm
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
            bookReservationTableLayoutPanel = new TableLayoutPanel();
            filterLayoutPanel = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            usersMultiSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            label1 = new Label();
            booksMultiSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            statusDropdown = new LibraryManagementSystem.Winforms.component.CustomDropdown();
            tableLayoutPanel1 = new TableLayoutPanel();
            refresh = new Button();
            returnBook = new Button();
            addReservation = new Button();
            BookReservationTableView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Book = new DataGridViewTextBoxColumn();
            issuedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookReservationBindingSource = new BindingSource(components);
            bookReserVationtableBindingSource = new BindingSource(components);
            bookReservationTableLayoutPanel.SuspendLayout();
            filterLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookReservationTableView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookReservationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookReserVationtableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bookReservationTableLayoutPanel
            // 
            bookReservationTableLayoutPanel.ColumnCount = 3;
            bookReservationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            bookReservationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            bookReservationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            bookReservationTableLayoutPanel.Controls.Add(filterLayoutPanel, 2, 0);
            bookReservationTableLayoutPanel.Controls.Add(tableLayoutPanel1, 2, 1);
            bookReservationTableLayoutPanel.Controls.Add(BookReservationTableView, 2, 2);
            bookReservationTableLayoutPanel.Dock = DockStyle.Fill;
            bookReservationTableLayoutPanel.Location = new Point(0, 0);
            bookReservationTableLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            bookReservationTableLayoutPanel.Name = "bookReservationTableLayoutPanel";
            bookReservationTableLayoutPanel.RowCount = 4;
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 755F));
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bookReservationTableLayoutPanel.Size = new Size(1367, 1024);
            bookReservationTableLayoutPanel.TabIndex = 0;
            // 
            // filterLayoutPanel
            // 
            filterLayoutPanel.ColumnCount = 7;
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 296F));
            filterLayoutPanel.Controls.Add(label3, 4, 0);
            filterLayoutPanel.Controls.Add(label2, 2, 0);
            filterLayoutPanel.Controls.Add(usersMultiSelectComboBox, 1, 0);
            filterLayoutPanel.Controls.Add(label1, 0, 0);
            filterLayoutPanel.Controls.Add(booksMultiSelectComboBox, 3, 0);
            filterLayoutPanel.Controls.Add(statusDropdown, 5, 0);
            filterLayoutPanel.Dock = DockStyle.Fill;
            filterLayoutPanel.Location = new Point(24, 2);
            filterLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            filterLayoutPanel.Name = "filterLayoutPanel";
            filterLayoutPanel.RowCount = 1;
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            filterLayoutPanel.Size = new Size(1618, 49);
            filterLayoutPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(799, 8);
            label3.Margin = new Padding(8);
            label3.Name = "label3";
            label3.Size = new Size(83, 33);
            label3.TabIndex = 5;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(400, 8);
            label2.Margin = new Padding(8);
            label2.Name = "label2";
            label2.Size = new Size(83, 33);
            label2.TabIndex = 4;
            label2.Text = "Books:";
            // 
            // usersMultiSelectComboBox
            // 
            usersMultiSelectComboBox.LabelText = "";
            usersMultiSelectComboBox.Location = new Point(96, 2);
            usersMultiSelectComboBox.Margin = new Padding(4, 2, 4, 2);
            usersMultiSelectComboBox.Name = "usersMultiSelectComboBox";
            usersMultiSelectComboBox.Size = new Size(292, 45);
            usersMultiSelectComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(8, 8);
            label1.Margin = new Padding(8);
            label1.Name = "label1";
            label1.Size = new Size(76, 33);
            label1.TabIndex = 3;
            label1.Text = "Users:";
            // 
            // booksMultiSelectComboBox
            // 
            booksMultiSelectComboBox.LabelText = "";
            booksMultiSelectComboBox.Location = new Point(495, 2);
            booksMultiSelectComboBox.Margin = new Padding(4, 2, 4, 2);
            booksMultiSelectComboBox.Name = "booksMultiSelectComboBox";
            booksMultiSelectComboBox.Size = new Size(292, 45);
            booksMultiSelectComboBox.TabIndex = 1;
            // 
            // statusDropdown
            // 
            statusDropdown.AccessibleName = "";
            statusDropdown.Location = new Point(893, 3);
            statusDropdown.Name = "statusDropdown";
            statusDropdown.Size = new Size(217, 42);
            statusDropdown.TabIndex = 6;
            statusDropdown.Tag = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(refresh, 2, 0);
            tableLayoutPanel1.Controls.Add(returnBook, 1, 0);
            tableLayoutPanel1.Controls.Add(addReservation, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(24, 55);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1618, 81);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // refresh
            // 
            refresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            refresh.Location = new Point(1249, 9);
            refresh.Margin = new Padding(7, 9, 7, 9);
            refresh.Name = "refresh";
            refresh.Padding = new Padding(7, 9, 7, 9);
            refresh.Size = new Size(197, 63);
            refresh.TabIndex = 2;
            refresh.Text = "Refersh";
            refresh.UseVisualStyleBackColor = true;
            // 
            // returnBook
            // 
            returnBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            returnBook.Location = new Point(620, 9);
            returnBook.Margin = new Padding(7, 9, 7, 9);
            returnBook.Name = "returnBook";
            returnBook.Padding = new Padding(7, 9, 7, 9);
            returnBook.Size = new Size(377, 63);
            returnBook.TabIndex = 1;
            returnBook.Text = "ReturnBook";
            returnBook.UseVisualStyleBackColor = true;
            returnBook.Click += returnBook_Click;
            // 
            // addReservation
            // 
            addReservation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addReservation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addReservation.Location = new Point(61, 9);
            addReservation.Margin = new Padding(7, 9, 7, 9);
            addReservation.Name = "addReservation";
            addReservation.Padding = new Padding(7, 9, 7, 9);
            addReservation.Size = new Size(416, 63);
            addReservation.TabIndex = 0;
            addReservation.Text = "AddReservation";
            addReservation.UseVisualStyleBackColor = true;
            addReservation.Click += addReservation_Click;
            // 
            // BookReservationTableView
            // 
            BookReservationTableView.AllowUserToOrderColumns = true;
            BookReservationTableView.AutoGenerateColumns = false;
            BookReservationTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookReservationTableView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            BookReservationTableView.ColumnHeadersHeight = 46;
            BookReservationTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BookReservationTableView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, UserName, Book, issuedDateDataGridViewTextBoxColumn, dueDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            BookReservationTableView.DataSource = bookReservationBindingSource;
            BookReservationTableView.Dock = DockStyle.Fill;
            BookReservationTableView.Location = new Point(24, 140);
            BookReservationTableView.Margin = new Padding(4, 2, 4, 2);
            BookReservationTableView.Name = "BookReservationTableView";
            BookReservationTableView.RowHeadersVisible = false;
            BookReservationTableView.RowHeadersWidth = 82;
            BookReservationTableView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            BookReservationTableView.Size = new Size(1618, 751);
            BookReservationTableView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 10;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 10;
            UserName.Name = "UserName";
            // 
            // Book
            // 
            Book.DataPropertyName = "BookTitle";
            Book.HeaderText = "Book";
            Book.MinimumWidth = 10;
            Book.Name = "Book";
            // 
            // issuedDateDataGridViewTextBoxColumn
            // 
            issuedDateDataGridViewTextBoxColumn.DataPropertyName = "IssuedDate";
            issuedDateDataGridViewTextBoxColumn.HeaderText = "IssuedDate";
            issuedDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            issuedDateDataGridViewTextBoxColumn.Name = "issuedDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // bookReservationBindingSource
            // 
            bookReservationBindingSource.DataSource = typeof(Models.BookReservations.BookReservation);
            // 
            // BookReservationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 1024);
            Controls.Add(bookReservationTableLayoutPanel);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BookReservationForm";
            Text = "BookReservationtable";
            bookReservationTableLayoutPanel.ResumeLayout(false);
            filterLayoutPanel.ResumeLayout(false);
            filterLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BookReservationTableView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookReservationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookReserVationtableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel bookReservationTableLayoutPanel;
        private TableLayoutPanel filterLayoutPanel;
        private Component.MultiSelectComboBox booksMultiSelectComboBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button refresh;
        private Button addReservation;
        private Button returnBook;
        private BindingSource bookReserVationtableBindingSource;
        private DataGridView BookReservationTableView;
        private BindingSource bookReservationBindingSource;
        private DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Book;
        private DataGridViewTextBoxColumn issuedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Component.MultiSelectComboBox usersMultiSelectComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private component.CustomDropdown statusDropdown;
    }
}
