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
        }

        private async void BookListForm_Load(object? sender, EventArgs e)
        {
            var token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                await ShowBooksAsync();
            }
            else
            {
                MessageBox.Show("No token found. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private async Task ShowBooksAsync(List<string>? filterIds = null)
        {
            var token = Properties.Settings.Default.JwtToken;
            using var client = ApiClientHelper.CreateClient();

            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                // Build the query string with the bookIds if filterIds is not null or empty
                string url = "books";

                if (filterIds != null && filterIds.Any())
                {
                    // Join the book IDs into a comma-separated list for the 'bookIds' query parameter
                    string bookIdsQuery = string.Join(",", filterIds);
                    url += $"?bookIds={bookIdsQuery}";
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


        private async void multiSelectComboBox1_Load(object sender, EventArgs e)
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

                        multiSelectComboBox1.SetItems(options); // assuming your control has this method
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

    }
}