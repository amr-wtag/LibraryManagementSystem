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
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            booksLayoutPanel.SuspendLayout();
            filterTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
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
            booksLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            booksLayoutPanel.Controls.Add(filterTableLayoutPanel, 0, 0);
            booksLayoutPanel.Controls.Add(dataGridViewBooks, 0, 1);
            booksLayoutPanel.Dock = DockStyle.Fill;
            booksLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            booksLayoutPanel.Location = new Point(0, 0);
            booksLayoutPanel.Name = "booksLayoutPanel";
            booksLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            booksLayoutPanel.RowStyles.Add(new RowStyle());
            booksLayoutPanel.Size = new Size(1142, 925);
            booksLayoutPanel.TabIndex = 1;
            // 
            // filterTableLayoutPanel
            // 
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 328F));
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            filterTableLayoutPanel.Controls.Add(bookSelectComboBox, 0, 0);
            filterTableLayoutPanel.Controls.Add(multiSelectComboBox3, 2, 0);
            filterTableLayoutPanel.Controls.Add(authorSelectComboBox, 1, 0);
            filterTableLayoutPanel.Dock = DockStyle.Fill;
            filterTableLayoutPanel.Location = new Point(3, 3);
            filterTableLayoutPanel.Name = "filterTableLayoutPanel";
            filterTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            filterTableLayoutPanel.Size = new Size(1136, 44);
            filterTableLayoutPanel.TabIndex = 0;
            // 
            // bookSelectComboBox
            // 
            bookSelectComboBox.Dock = DockStyle.Fill;
            bookSelectComboBox.LabelText = "Select Books:";
            bookSelectComboBox.Location = new Point(3, 3);
            bookSelectComboBox.Name = "bookSelectComboBox";
            bookSelectComboBox.Size = new Size(178, 38);
            bookSelectComboBox.TabIndex = 0;
            // 
            // multiSelectComboBox3
            // 
            multiSelectComboBox3.Dock = DockStyle.Fill;
            multiSelectComboBox3.LabelText = "Select...";
            multiSelectComboBox3.Location = new Point(515, 3);
            multiSelectComboBox3.Name = "multiSelectComboBox3";
            multiSelectComboBox3.Size = new Size(618, 38);
            multiSelectComboBox3.TabIndex = 1;
            // 
            // authorSelectComboBox
            // 
            authorSelectComboBox.Dock = DockStyle.Fill;
            authorSelectComboBox.LabelText = "Select Author:";
            authorSelectComboBox.Location = new Point(187, 3);
            authorSelectComboBox.Name = "authorSelectComboBox";
            authorSelectComboBox.Size = new Size(322, 38);
            authorSelectComboBox.TabIndex = 2;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.ColumnHeadersHeight = 46;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, copiesAvailableDataGridViewTextBoxColumn, authorsDataGridViewTextBoxColumn, genresDataGridViewTextBoxColumn });
            dataGridViewBooks.DataSource = bookBindingSource;
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(3, 53);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new Size(1136, 899);
            dataGridViewBooks.TabIndex = 1;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // copiesAvailableDataGridViewTextBoxColumn
            // 
            copiesAvailableDataGridViewTextBoxColumn.DataPropertyName = "CopiesAvailable";
            copiesAvailableDataGridViewTextBoxColumn.MinimumWidth = 10;
            copiesAvailableDataGridViewTextBoxColumn.Name = "copiesAvailableDataGridViewTextBoxColumn";
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            authorsDataGridViewTextBoxColumn.MinimumWidth = 10;
            authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            // 
            // genresDataGridViewTextBoxColumn
            // 
            genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            genresDataGridViewTextBoxColumn.MinimumWidth = 10;
            genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 925);
            Controls.Add(booksLayoutPanel);
            Name = "BookListForm";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            booksLayoutPanel.ResumeLayout(false);
            filterTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip bookRowContextMenu;
        private BindingSource bookBindingSource;
        private TableLayoutPanel booksLayoutPanel;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn copiesAvailableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private TableLayoutPanel filterTableLayoutPanel;
        private Component.MultiSelectComboBox bookSelectComboBox;
        private Component.MultiSelectComboBox multiSelectComboBox3;
        private Component.MultiSelectComboBox authorSelectComboBox;
    }
}
