using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Books;

namespace LibraryManagementSystem.Winforms.Forms.BookUpdate
{
    public partial class BookUpdateFrom : Form
    {
        public BookUpdateFrom(Models.Books.BookDisplayModel selectedBook)
        {
            InitializeComponent();
            textBox1.Text = selectedBook.Title;

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
    }
}
