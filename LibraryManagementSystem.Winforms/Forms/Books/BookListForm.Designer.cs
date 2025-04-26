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
            dataGridViewBooks = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            copiesAvailableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            bookSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            authorSelectComboBox = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            multiSelectComboBox3 = new LibraryManagementSystem.Winforms.Component.MultiSelectComboBox();
            filterTableLayoutPanel = new TableLayoutPanel();
            bookRowContextMenu = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            filterTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.ColumnHeadersHeight = 46;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, copiesAvailableDataGridViewTextBoxColumn, authorsDataGridViewTextBoxColumn, genresDataGridViewTextBoxColumn });
            dataGridViewBooks.DataSource = bookBindingSource;
            dataGridViewBooks.Location = new Point(0, 110);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new Size(1462, 1053);
            dataGridViewBooks.TabIndex = 1;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // copiesAvailableDataGridViewTextBoxColumn
            // 
            copiesAvailableDataGridViewTextBoxColumn.DataPropertyName = "CopiesAvailable";
            copiesAvailableDataGridViewTextBoxColumn.HeaderText = "CopiesAvailable";
            copiesAvailableDataGridViewTextBoxColumn.MinimumWidth = 10;
            copiesAvailableDataGridViewTextBoxColumn.Name = "copiesAvailableDataGridViewTextBoxColumn";
            copiesAvailableDataGridViewTextBoxColumn.Width = 200;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            authorsDataGridViewTextBoxColumn.HeaderText = "Authors";
            authorsDataGridViewTextBoxColumn.MinimumWidth = 10;
            authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            authorsDataGridViewTextBoxColumn.Width = 200;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            genresDataGridViewTextBoxColumn.MinimumWidth = 10;
            genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            genresDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Books.Book);
            // 
            // bookSelectComboBox
            // 
            bookSelectComboBox.Dock = DockStyle.Bottom;
            bookSelectComboBox.LabelText = "Select Books:";
            bookSelectComboBox.Location = new Point(3, 51);
            bookSelectComboBox.Name = "bookSelectComboBox";
            bookSelectComboBox.Size = new Size(407, 50);
            bookSelectComboBox.TabIndex = 2;
            // 
            // authorSelectComboBox
            // 
            authorSelectComboBox.Dock = DockStyle.Bottom;
            authorSelectComboBox.LabelText = "Select Author:";
            authorSelectComboBox.Location = new Point(416, 51);
            authorSelectComboBox.Name = "authorSelectComboBox";
            authorSelectComboBox.Size = new Size(426, 50);
            authorSelectComboBox.TabIndex = 3;
            // 
            // multiSelectComboBox3
            // 
            multiSelectComboBox3.Dock = DockStyle.Bottom;
            multiSelectComboBox3.LabelText = "Select...";
            multiSelectComboBox3.Location = new Point(848, 51);
            multiSelectComboBox3.Name = "multiSelectComboBox3";
            multiSelectComboBox3.Size = new Size(384, 50);
            multiSelectComboBox3.TabIndex = 4;
            // 
            // filterTableLayoutPanel
            // 
            filterTableLayoutPanel.ColumnCount = 4;
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.8435364F));
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.1564636F));
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 390F));
            filterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            filterTableLayoutPanel.Controls.Add(bookSelectComboBox, 0, 0);
            filterTableLayoutPanel.Controls.Add(multiSelectComboBox3, 2, 0);
            filterTableLayoutPanel.Controls.Add(authorSelectComboBox, 1, 0);
            filterTableLayoutPanel.Dock = DockStyle.Top;
            filterTableLayoutPanel.Location = new Point(0, 0);
            filterTableLayoutPanel.Name = "filterTableLayoutPanel";
            filterTableLayoutPanel.RowCount = 1;
            filterTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            filterTableLayoutPanel.Size = new Size(1462, 104);
            filterTableLayoutPanel.TabIndex = 5;
            // 
            // bookRowContextMenu
            // 
            bookRowContextMenu.ImageScalingSize = new Size(32, 32);
            bookRowContextMenu.Name = "contextMenuStrip4";
            bookRowContextMenu.Size = new Size(61, 4);
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 1163);
            Controls.Add(filterTableLayoutPanel);
            Controls.Add(dataGridViewBooks);
            Margin = new Padding(6);
            Name = "BookListForm";
            Text = "Book List";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            filterTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewBooks;

        #endregion

        private Component.MultiSelectComboBox bookSelectComboBox;
        private Component.MultiSelectComboBox authorSelectComboBox;
        private Component.MultiSelectComboBox multiSelectComboBox3;
        private TableLayoutPanel filterTableLayoutPanel;
        private ContextMenuStrip bookRowContextMenu;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn copiesAvailableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
    }
}
