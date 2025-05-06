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
            components = new System.ComponentModel.Container();
            bookBindingSource = new BindingSource(components);
            bookRowContextMenu = new ContextMenuStrip(components);
            booksLayoutPanel = new TableLayoutPanel();
            filterTableLayoutPanel = new TableLayoutPanel();
            bookSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            multiSelectComboBox3 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            authorSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            dataGridViewBooks = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            copiesAvailableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource2 = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            bookDtoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            booksLayoutPanel.SuspendLayout();
            filterTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Books.Book);
            // 
            // bookRowContextMenu
            // 
            bookRowContextMenu.ImageScalingSize = new Size(32, 32);
            bookRowContextMenu.Name = "contextMenuStrip4";
            bookRowContextMenu.Size = new Size(61, 4);
            // 
            // booksLayoutPanel
            // 
            booksLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            booksLayoutPanel.Controls.Add(filterTableLayoutPanel, 0, 0);
            booksLayoutPanel.Controls.Add(dataGridViewBooks, 0, 1);
            booksLayoutPanel.Dock = DockStyle.Fill;
            booksLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            booksLayoutPanel.Location = new Point(0, 0);
            booksLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            booksLayoutPanel.Name = "booksLayoutPanel";
            booksLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            booksLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            booksLayoutPanel.Size = new Size(1736, 1203);
            booksLayoutPanel.TabIndex = 1;
            // 
            // filterTableLayoutPanel
            // 
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 371F));
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 371F));
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 986F));
            filterTableLayoutPanel.Controls.Add(bookSelectComboBox, 0, 0);
            filterTableLayoutPanel.Controls.Add(multiSelectComboBox3, 2, 0);
            filterTableLayoutPanel.Controls.Add(authorSelectComboBox, 1, 0);
            filterTableLayoutPanel.Dock = DockStyle.Fill;
            filterTableLayoutPanel.Location = new Point(4, 2);
            filterTableLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            filterTableLayoutPanel.Name = "filterTableLayoutPanel";
            filterTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            filterTableLayoutPanel.Size = new Size(1728, 45);
            filterTableLayoutPanel.TabIndex = 0;
            // 
            // bookSelectComboBox
            // 
            bookSelectComboBox.Dock = DockStyle.Fill;
            bookSelectComboBox.LabelText = "Select Books:";
            bookSelectComboBox.Location = new Point(4, 2);
            bookSelectComboBox.Margin = new Padding(4, 2, 4, 2);
            bookSelectComboBox.Name = "bookSelectComboBox";
            bookSelectComboBox.Size = new Size(363, 41);
            bookSelectComboBox.TabIndex = 0;
            // 
            // multiSelectComboBox3
            // 
            multiSelectComboBox3.Dock = DockStyle.Left;
            multiSelectComboBox3.LabelText = "Select Genres:";
            multiSelectComboBox3.Location = new Point(746, 2);
            multiSelectComboBox3.Margin = new Padding(4, 2, 4, 2);
            multiSelectComboBox3.Name = "multiSelectComboBox3";
            multiSelectComboBox3.Size = new Size(371, 41);
            multiSelectComboBox3.TabIndex = 1;
            // 
            // authorSelectComboBox
            // 
            authorSelectComboBox.Dock = DockStyle.Fill;
            authorSelectComboBox.LabelText = "Select Authors:";
            authorSelectComboBox.Location = new Point(375, 2);
            authorSelectComboBox.Margin = new Padding(4, 2, 4, 2);
            authorSelectComboBox.Name = "authorSelectComboBox";
            authorSelectComboBox.Size = new Size(363, 41);
            authorSelectComboBox.TabIndex = 2;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.ColumnHeadersHeight = 46;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, copiesAvailableDataGridViewTextBoxColumn, authorsDataGridViewTextBoxColumn, genresDataGridViewTextBoxColumn });
            dataGridViewBooks.DataSource = bookBindingSource2;
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(4, 51);
            dataGridViewBooks.Margin = new Padding(4, 2, 4, 2);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new Size(1728, 1150);
            dataGridViewBooks.TabIndex = 1;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // copiesAvailableDataGridViewTextBoxColumn
            // 
            copiesAvailableDataGridViewTextBoxColumn.DataPropertyName = "CopiesAvailable";
            copiesAvailableDataGridViewTextBoxColumn.HeaderText = "CopiesAvailable";
            copiesAvailableDataGridViewTextBoxColumn.MinimumWidth = 10;
            copiesAvailableDataGridViewTextBoxColumn.Name = "copiesAvailableDataGridViewTextBoxColumn";
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            authorsDataGridViewTextBoxColumn.HeaderText = "Authors";
            authorsDataGridViewTextBoxColumn.MinimumWidth = 10;
            authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            // 
            // genresDataGridViewTextBoxColumn
            // 
            genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            genresDataGridViewTextBoxColumn.MinimumWidth = 10;
            genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            // 
            // bookBindingSource2
            // 
            bookBindingSource2.DataSource = typeof(Models.Books.Book);
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(Models.Books.Book);
            // 
            // bookDtoBindingSource
            // 
            bookDtoBindingSource.DataSource = typeof(Models.BookDto);
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1736, 1203);
            Controls.Add(booksLayoutPanel);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BookListForm";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            booksLayoutPanel.ResumeLayout(false);
            filterTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookDtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip bookRowContextMenu;
        private BindingSource bookBindingSource;
        private TableLayoutPanel booksLayoutPanel;
        private DataGridView dataGridViewBooks;
        private TableLayoutPanel filterTableLayoutPanel;
        private Component.MultiSelectComboBox bookSelectComboBox;
        private Component.MultiSelectComboBox multiSelectComboBox3;
        private Component.MultiSelectComboBox authorSelectComboBox;
        private BindingSource bookBindingSource1;
        private BindingSource bookDtoBindingSource;
        private BindingSource bookBindingSource2;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn copiesAvailableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
    }
}
