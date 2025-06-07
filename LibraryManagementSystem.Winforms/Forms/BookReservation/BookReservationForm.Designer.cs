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
            multiSelectComboBox1 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            multiSelectComboBox2 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            multiSelectComboBox3 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            refresh = new Button();
            returnBook = new Button();
            addReservation = new Button();
            BookReservationTableView = new DataGridView();
            bookReservationBindingSource = new BindingSource(components);
            bookReserVationtableBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Book = new DataGridViewTextBoxColumn();
            issuedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            bookReservationTableLayoutPanel.RowCount = 3;
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            bookReservationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 755F));
            bookReservationTableLayoutPanel.Size = new Size(1623, 998);
            bookReservationTableLayoutPanel.TabIndex = 0;
            // 
            // filterLayoutPanel
            // 
            filterLayoutPanel.ColumnCount = 4;
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 371F));
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 371F));
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 371F));
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 505F));
            filterLayoutPanel.Controls.Add(multiSelectComboBox1, 0, 0);
            filterLayoutPanel.Controls.Add(multiSelectComboBox2, 1, 0);
            filterLayoutPanel.Controls.Add(multiSelectComboBox3, 2, 0);
            filterLayoutPanel.Dock = DockStyle.Fill;
            filterLayoutPanel.Location = new Point(24, 2);
            filterLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            filterLayoutPanel.Name = "filterLayoutPanel";
            filterLayoutPanel.RowCount = 1;
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            filterLayoutPanel.Size = new Size(1618, 49);
            filterLayoutPanel.TabIndex = 0;
            // 
            // multiSelectComboBox1
            // 
            multiSelectComboBox1.LabelText = "Users:";
            multiSelectComboBox1.Location = new Point(4, 2);
            multiSelectComboBox1.Margin = new Padding(4, 2, 4, 2);
            multiSelectComboBox1.Name = "multiSelectComboBox1";
            multiSelectComboBox1.Size = new Size(353, 45);
            multiSelectComboBox1.TabIndex = 0;
            // 
            // multiSelectComboBox2
            // 
            multiSelectComboBox2.LabelText = "Books:";
            multiSelectComboBox2.Location = new Point(375, 2);
            multiSelectComboBox2.Margin = new Padding(4, 2, 4, 2);
            multiSelectComboBox2.Name = "multiSelectComboBox2";
            multiSelectComboBox2.Size = new Size(363, 45);
            multiSelectComboBox2.TabIndex = 1;
            // 
            // multiSelectComboBox3
            // 
            multiSelectComboBox3.LabelText = "Status:";
            multiSelectComboBox3.Location = new Point(746, 2);
            multiSelectComboBox3.Margin = new Padding(4, 2, 4, 2);
            multiSelectComboBox3.Name = "multiSelectComboBox3";
            multiSelectComboBox3.Size = new Size(363, 45);
            multiSelectComboBox3.TabIndex = 2;
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
            BookReservationTableView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            BookReservationTableView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            BookReservationTableView.ColumnHeadersHeight = 46;
            BookReservationTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BookReservationTableView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, UserName, Book, issuedDateDataGridViewTextBoxColumn, dueDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            BookReservationTableView.DataSource = bookReservationBindingSource;
            BookReservationTableView.Dock = DockStyle.Fill;
            BookReservationTableView.Location = new Point(24, 140);
            BookReservationTableView.Margin = new Padding(4, 2, 4, 2);
            BookReservationTableView.Name = "BookReservationTableView";
            BookReservationTableView.RowHeadersWidth = 82;
            BookReservationTableView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            BookReservationTableView.Size = new Size(1618, 856);
            BookReservationTableView.TabIndex = 2;
            // 
            // bookReservationBindingSource
            // 
            bookReservationBindingSource.DataSource = typeof(Models.BookReservations.BookReservation);
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
            // BookReservationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1623, 998);
            Controls.Add(bookReservationTableLayoutPanel);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BookReservationForm";
            Text = "BookReservationtable";
            bookReservationTableLayoutPanel.ResumeLayout(false);
            filterLayoutPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BookReservationTableView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookReservationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookReserVationtableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel bookReservationTableLayoutPanel;
        private TableLayoutPanel filterLayoutPanel;
        private Component.MultiSelectComboBox multiSelectComboBox1;
        private Component.MultiSelectComboBox multiSelectComboBox2;
        private Component.MultiSelectComboBox multiSelectComboBox3;
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
    }
}
