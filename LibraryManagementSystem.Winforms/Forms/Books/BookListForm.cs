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
            //multiSelectComboBox1.SelectedValuesChanged += MultiSelectComboBox1_SelectedValuesChanged;
            //multiSelectComboBox2.SelectedValuesChanged += MultiSelectComboBox2_SelectedValuesChanged;
            //multiSelectComboBox3.SelectedValuesChanged += MultiSelectComboBo3_SelectedValuesChanged;
        }

        private async void BookListForm_Load(object? sender, EventArgs e)
        {
            var token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                await LoadBookFilterOptionsAsync(); // load options into multiselect
                await ShowBooksAsync();             // show all books initially
            }
            else
            {
                MessageBox.Show("No token found. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private async void MultiSelectComboBoxes_SelectedValuesChanged(object? sender, EventArgs e)
        {
            var selectedBookIds = multiSelectComboBox1
                .GetSelectedItems()
                .Select(opt => opt.Value.ToString())
                .ToList();
            var selectedAuthorIds = multiSelectComboBox2
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
                //string url = "books";

                //if (filterIds != null && filterIds.Any())
                //{
                //    string queryParams = string.Join("&", filterIds.Select(id => $"bookIds={id}"));
                //    url += $"?{queryParams}";
                //}

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

                Console.WriteLine($"Requesting URL: {url}"); // Optional: for debugging

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

                        multiSelectComboBox1.SetItems(options);
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

        private void multiSelectComboBox2_Load(object sender, EventArgs e)
        {

        }

        private void multiSelectComboBox3_Load(object sender, EventArgs e)
        {

        }
    }
}
