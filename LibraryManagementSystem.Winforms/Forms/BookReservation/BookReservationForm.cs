using System.Text.Json;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.BookReservations;

namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    public partial class BookReservationForm : Form
    {
        public BookReservationForm()
        {
            InitializeComponent();

            this.Load += BookReservationForm_Load;

        }


        private async void BookReservationForm_Load(object? sender, EventArgs e)
        {

            var token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                await ShowBookReservationsAsync();
            }
            else
            {
                MessageBox.Show("No token found. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private async Task ShowBookReservationsAsync()
        {
            var token = Properties.Settings.Default.JwtToken;
            using var client = ApiClientHelper.CreateClient();
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await client.GetAsync("bookreservation");
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var bookReservationsWrapper = JsonSerializer.Deserialize<BookReservationListResponse>(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var bookReservations = bookReservationsWrapper?.BookReservations;

                if (bookReservations != null)
                {
                    var displayBookReservations = bookReservations.Select(bookReservation => new BookReservationDisplayModal
                    {
                        Id = bookReservation.Id,
                        UserId = bookReservation.UserId,
                        IssuedDate = bookReservation.IssuedDate,
                        DueDate = bookReservation.DueDate,
                        ReturnDate = bookReservation.ReturnDate,
                        BookTitle = bookReservation.Book?.Title,
                    }).ToList();

                    BookReservationTableView.DataSource = bookReservations;
                }

            }
        }

        //private async void BookReservationTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    await ShowBookReservationsAsync();

        //}
    }
}
