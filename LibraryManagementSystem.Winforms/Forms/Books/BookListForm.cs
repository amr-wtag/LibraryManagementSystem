using System.Data;
using System.Text.Json;
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

        private async Task ShowBooksAsync()
        {
            var token = Properties.Settings.Default.JwtToken;
            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5049"); // replace with your actual backend
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);


            try
            {
                var response = await client.GetAsync("/api/books");
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var booksWrapper = JsonSerializer.Deserialize<BookListResponse>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var books = booksWrapper?.Value;

                    // MessageBox.Show($"Books count: {result}");
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}