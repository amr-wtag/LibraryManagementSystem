using System.Data;
using System.Text.Json;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Books;

namespace LibraryManagementSystem.Winforms.Forms.Books
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();

            this.Load += BookListForm_Load;

            // Hook up event handlers
            bookSelectComboBox.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
            authorSelectComboBox.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
            multiSelectComboBox3.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
        }

        private async void BookListForm_Load(object? sender, EventArgs e)
        {
            var token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                await LoadBookFilterOptionsAsync();
                await LoadAuthorFilterOptionsAsync();
                //await LoadGenreFilterOptionsAsync();
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

                if (response.IsSuccessStatusCode)
                {
                    var booksWrapper = JsonSerializer.Deserialize<BookListResponse>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var books = booksWrapper?.Value;

                    if (books != null)
                    {
                        var displayBooks = books.Select(book => new BookDisplayModel
                        {
                            Title = book.Title ?? "",
                            CopiesAvailable = book.CopiesAvailable,
                        }).ToList();

                        dataGridViewBooks.DataSource = displayBooks;
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
            var token = Properties.Settings.Default.JwtToken;
            using var client = ApiClientHelper.CreateClient();
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                var response = await client.GetAsync("books/id-titles");
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonSerializer.Deserialize<BookSummaryResponse>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var books = responseObject?.Values;

                    if (books != null && books.Any())
                    {
                        var options = books.Select(book => new DropDownOption
                        {
                            Label = book.Title ?? "(Untitled)",
                            Value = book.Id
                        }).ToList();

                        bookSelectComboBox.SetItems(options);
                    }
                    else
                    {
                        MessageBox.Show("No books available.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fetch book list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task LoadAuthorFilterOptionsAsync()
        {
            var token = Properties.Settings.Default.JwtToken;
            using var client = ApiClientHelper.CreateClient();
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

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
    }
}
