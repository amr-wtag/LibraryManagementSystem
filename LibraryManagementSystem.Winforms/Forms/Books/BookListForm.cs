using System.Data;
using System.Text.Json;
using LibraryManagementSystem.Winforms.dataHelpers;
using LibraryManagementSystem.Winforms.Forms.BookUpdate;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Books;

namespace LibraryManagementSystem.Winforms.Forms.Books
{
    public partial class BookListForm : Form
    {
        private ToolStripMenuItem viewDetailsMenuItem;
        private ToolStripMenuItem editBookMenuItem;

        public BookListForm()
        {
            InitializeComponent();

            InitializeContextMenu();

            this.Load += BookListForm_Load;

            // Hook up event handlers
            bookSelectComboBox.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
            authorSelectComboBox.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
            multiSelectComboBox3.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
            dataGridViewBooks.CellMouseClick += DataGridViewBooks_CellMouseClick;
        }

        private void InitializeContextMenu()
        {
            bookRowContextMenu = new ContextMenuStrip();

            viewDetailsMenuItem = new ToolStripMenuItem("View Details");
            viewDetailsMenuItem.Click += ViewDetails_Click;

            editBookMenuItem = new ToolStripMenuItem("Edit Book");
            editBookMenuItem.Click += EditBook_Click;

            bookRowContextMenu.Items.AddRange(new ToolStripItem[]
            {
                viewDetailsMenuItem,
                editBookMenuItem
            });
        }

        private async void BookListForm_Load(object? sender, EventArgs e)
        {
            var token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                await LoadBookFilterOptionsAsync();
                await LoadAuthorFilterOptionsAsync();
                await ShowBooksAsync(); // Show all books initially
            }
            else
            {
                MessageBox.Show("No token found. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private async void MultiSelectComboBoxes_SelectedValuesChanged(object? sender, EventArgs e)
        {
            var selectedBookIds = bookSelectComboBox
                .GetSelectedItems()
                .Select(opt => opt.Value.ToString())
                .ToList();

            var selectedAuthorIds = authorSelectComboBox
                .GetSelectedItems()
                .Select(opt => opt.Value.ToString())
                .ToList();

            var selectedGenreIds = multiSelectComboBox3
                .GetSelectedItems()
                .Select(opt => opt.Value.ToString())
                .ToList();

            await ShowBooksAsync(selectedBookIds, selectedAuthorIds, selectedGenreIds);
        }

        private async Task ShowBooksAsync(List<string>? bookIds = null, List<string>? authorIds = null, List<string>? genreIds = null)
        {
            var token = Properties.Settings.Default.JwtToken;
            using var client = ApiClientHelper.CreateClient();

            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                var queryParts = new List<string>();

                if (bookIds != null && bookIds.Any())
                    queryParts.AddRange(bookIds.Select(id => $"bookIds={id}"));

                if (authorIds != null && authorIds.Any())
                    queryParts.AddRange(authorIds.Select(id => $"authorIds={id}"));

                if (genreIds != null && genreIds.Any())
                    queryParts.AddRange(genreIds.Select(id => $"genreIds={id}"));

                string url = "books";
                if (queryParts.Any())
                {
                    url += "?" + string.Join("&", queryParts);
                }

                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                dataGridViewBooks.Visible = true;

                if (response.IsSuccessStatusCode)
                {
                    var booksWrapper = JsonSerializer.Deserialize<BookListResponse>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var books = booksWrapper?.Value;

                    if (books != null)
                    {
                        dataGridViewBooks.Visible = false;
                        dataGridViewBooks.SuspendLayout();


                        var displayBooks = books.Select(book => new BookDisplayModel
                        {
                            Title = book.Title ?? "",
                            CopiesAvailable = book.CopiesAvailable,
                            Authors = book.Authors != null
                                ? string.Join(", ", book.Authors.Values.Select(author => author.Name)) : "",
                            AuthorIds = book.Authors != null
        ? book.Authors.Values.Select(author => author.Id).ToList()
        : new List<Guid>(),
                            Genres = book.Genres != null
                                ? string.Join(", ", book.Genres.Values.Select(genre => genre.Name)) : ""
                        }).ToList();

                        dataGridViewBooks.DataSource = null;
                        dataGridViewBooks.DataSource = displayBooks;
                        dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        dataGridViewBooks.ResumeLayout();
                        dataGridViewBooks.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fetch books from the API.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadBookFilterOptionsAsync()
        {
            var options = await BookDropdownHelper.LoadBookOptionsAsync();

            if (options.Any())
            {
                bookSelectComboBox.SetItems(options);
            }
        }

        private async Task LoadAuthorFilterOptionsAsync()
        {
            using var client = ApiClientHelper.CreateClient();

            try
            {
                var response = await client.GetAsync("author/id-titles");
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonSerializer.Deserialize<AuthorSummaryResponse>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var authors = responseObject?.Values;

                    if (authors != null && authors.Any())
                    {
                        var options = authors.Select(author => new DropDownOption
                        {
                            Label = author.Name ?? "(Unnamed)",
                            Value = author.Id
                        }).ToList();

                        authorSelectComboBox.SetItems(options);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fetch authors.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading authors: " + ex.Message);
            }
        }

        private void DataGridViewBooks_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridViewBooks.ClearSelection();
                dataGridViewBooks.Rows[e.RowIndex].Selected = true;

                bookRowContextMenu.Show(Cursor.Position);
            }
        }

        private void ViewDetails_Click(object? sender, EventArgs e)
        {
            var selectedBook = GetSelectedBook();
            if (selectedBook != null)
            {
                MessageBox.Show(
                    $"Title: {selectedBook.Title}\n" +
                    $"Available: {selectedBook.CopiesAvailable}\n" +
                    $"BookAuthors: {selectedBook.Authors}\n" +
                    $"BookGenre: {selectedBook.Genres}",
                    "Book Details"
                );
            }
        }

        private void EditBook_Click(object? sender, EventArgs e)
        {
            var selectedBook = GetSelectedBook();

            if (selectedBook != null)
            {
                var bookUpdateFrom = new BookUpdateFrom(selectedBook);
                this.Hide();

                bookUpdateFrom.Show();
                //MessageBox.Show(
                //    $"(EDIT MODE)\nTitle: {selectedBook.Title}\n" +
                //    $"Available: {selectedBook.CopiesAvailable}\n" +
                //    $"BookAuthors: {selectedBook.Authors}\n" +
                //    $"BookGenre: {selectedBook.Genres}",
                //    "Edit Book"
                //);



                // TODO: Replace with EditBookForm or logic
                // var editForm = new EditBookForm(selectedBook);
                // editForm.ShowDialog();
            }
        }

        private BookDisplayModel? GetSelectedBook()
        {
            return dataGridViewBooks.SelectedRows.Count > 0
                ? dataGridViewBooks.SelectedRows[0].DataBoundItem as BookDisplayModel
                : null;
        }
    }
}
