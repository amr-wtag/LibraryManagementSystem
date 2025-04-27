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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
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
            resources.ApplyResources(bookRowContextMenu, "bookRowContextMenu");
            bookRowContextMenu.ImageScalingSize = new Size(32, 32);
            bookRowContextMenu.Name = "contextMenuStrip4";
            // 
            // booksLayoutPanel
            // 
            resources.ApplyResources(booksLayoutPanel, "booksLayoutPanel");
            booksLayoutPanel.Controls.Add(filterTableLayoutPanel, 0, 0);
            booksLayoutPanel.Controls.Add(dataGridViewBooks, 0, 1);
            booksLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            booksLayoutPanel.Name = "booksLayoutPanel";
            booksLayoutPanel.Dock = DockStyle.Fill;
            // 
            // filterTableLayoutPanel
            // 
            resources.ApplyResources(filterTableLayoutPanel, "filterTableLayoutPanel");
            filterTableLayoutPanel.Controls.Add(bookSelectComboBox, 0, 0);
            filterTableLayoutPanel.Controls.Add(multiSelectComboBox3, 2, 0);
            filterTableLayoutPanel.Controls.Add(authorSelectComboBox, 1, 0);
            filterTableLayoutPanel.Name = "filterTableLayoutPanel";
            // 
            // bookSelectComboBox
            // 
            resources.ApplyResources(bookSelectComboBox, "bookSelectComboBox");
            bookSelectComboBox.LabelText = "Select Books:";
            bookSelectComboBox.Name = "bookSelectComboBox";
            // 
            // multiSelectComboBox3
            // 
            resources.ApplyResources(multiSelectComboBox3, "multiSelectComboBox3");
            multiSelectComboBox3.LabelText = "Select...";
            multiSelectComboBox3.Name = "multiSelectComboBox3";
            // 
            // authorSelectComboBox
            // 
            resources.ApplyResources(authorSelectComboBox, "authorSelectComboBox");
            authorSelectComboBox.LabelText = "Select Author:";
            authorSelectComboBox.Name = "authorSelectComboBox";
            // 
            // dataGridViewBooks
            // 
            resources.ApplyResources(dataGridViewBooks, "dataGridViewBooks");
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, copiesAvailableDataGridViewTextBoxColumn, authorsDataGridViewTextBoxColumn, genresDataGridViewTextBoxColumn });
            dataGridViewBooks.DataSource = bookBindingSource;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Dock = DockStyle.Fill;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            resources.ApplyResources(titleDataGridViewTextBoxColumn, "titleDataGridViewTextBoxColumn");
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // copiesAvailableDataGridViewTextBoxColumn
            // 
            copiesAvailableDataGridViewTextBoxColumn.DataPropertyName = "CopiesAvailable";
            resources.ApplyResources(copiesAvailableDataGridViewTextBoxColumn, "copiesAvailableDataGridViewTextBoxColumn");
            copiesAvailableDataGridViewTextBoxColumn.Name = "copiesAvailableDataGridViewTextBoxColumn";
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            resources.ApplyResources(authorsDataGridViewTextBoxColumn, "authorsDataGridViewTextBoxColumn");
            authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            // 
            // genresDataGridViewTextBoxColumn
            // 
            genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            resources.ApplyResources(genresDataGridViewTextBoxColumn, "genresDataGridViewTextBoxColumn");
            genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            // 
            // BookListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(booksLayoutPanel);
            Name = "BookListForm";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            booksLayoutPanel.ResumeLayout(false);
            filterTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
