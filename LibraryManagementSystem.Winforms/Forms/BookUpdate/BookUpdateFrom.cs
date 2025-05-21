using System.Data;
using System.Net.Http.Json;
using System.Text.Json;
using LibraryManagementSystem.Winforms.DTOs;
using LibraryManagementSystem.Winforms.Forms.Dashboard;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Books;


namespace LibraryManagementSystem.Winforms.Forms.BookUpdate
{
    public partial class BookUpdateFrom : Form
    {
        public Guid bookId;
        public BookUpdateFrom(Models.Books.BookDisplayModel selectedBook)
        {
            InitializeComponent();
            bookId = selectedBook.Id;
            textBox1.Text = selectedBook.Title;
            booksAvailableTextBox.Text = selectedBook.CopiesAvailable.ToString();

            _selectedAuthorIds = selectedBook.AuthorIds?.Select(a => a).ToList() ?? new List<Guid>();
            _selectedGenreIds = selectedBook.GenreIds?.Select(a => a).ToList() ?? new List<Guid>();
            LoadAuthorsList();
            LoadGenreList();
        }

        private List<Guid> _selectedAuthorIds = new();
        private List<Guid> _selectedGenreIds = new();

        private async void LoadAuthorsList()
        {
            await LoadAuthorFilterOptionsAsync();
        }

        private async void LoadGenreList()
        {
            await LoadGenreFilterOptionsAsync();
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

                        if (_selectedAuthorIds != null && _selectedAuthorIds.Count != 0)
                        {
                            authorSelectComboBox.SetSelectedValues(
    _selectedAuthorIds.Select(id => id.ToString()).ToList()
);
                        }
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
        private async Task LoadGenreFilterOptionsAsync()
        {
            using var client = ApiClientHelper.CreateClient();

            try
            {
                var response = await client.GetAsync("genre/id-names");
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonSerializer.Deserialize<GenreSummaryResponse>(result, new JsonSerializerOptions
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



                        genreSelectComboBox.SetItems(options);

                        if (_selectedGenreIds != null && _selectedGenreIds.Count != 0)
                        {
                            genreSelectComboBox.SetSelectedValues(
    _selectedGenreIds.Select(id => id.ToString()).ToList()
);
                        }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var dashboardForm = new DashboardForm();

            this.Hide();
            dashboardForm.Show();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            if (!Guid.TryParse(bookId.ToString(), out Guid parsedId))
            {
                MessageBox.Show("Invalid book ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            if (!int.TryParse(booksAvailableTextBox.Text.Trim(), out int copiesAvailable))
            {
                MessageBox.Show("Invalid number of copies.");
                return;
            }

            var authorIds = authorSelectComboBox.GetSelectedItems()
    .Select(val => Guid.Parse(val.Value.ToString())).ToList();

            var genreIds = genreSelectComboBox.GetSelectedItems()
                .Select(val => Guid.Parse(val.Value.ToString())).ToList();


            var bookRequest = new BookRequestDto
            {
                Id = parsedId,
                Title = textBox1.Text.Trim(),
                CopiesAvailable = copiesAvailable,
                AuthorIds = authorIds,
                GenreIds = genreIds
            };

            try
            {
                using var client = ApiClientHelper.CreateClient();
                var response = await client.PutAsJsonAsync($"books/{bookId}", bookRequest);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var dashboardForm = new DashboardForm();
                    this.Hide(); // or use this.Close() if you don't need to come back
                    dashboardForm.Show();


                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to update book.\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
