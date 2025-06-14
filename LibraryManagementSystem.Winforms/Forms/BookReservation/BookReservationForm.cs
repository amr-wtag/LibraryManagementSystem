using LibraryManagementSystem.Winforms.dataHelpers;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.BookReservations;
using LibraryManagementSystem.Winforms.Models.Users;
using System.Net.Http.Json;
using System.Text.Json;

namespace LibraryManagementSystem.Winforms.Forms.BookReservation
{
    public partial class BookReservationForm : Form
    {
        public BookReservationForm()
        {
            InitializeComponent();

            this.Load += BookReservationForm_Load;
            booksMultiSelectComboBox.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
            usersMultiSelectComboBox.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;
            statusMultiSelectComboBox.SelectedValuesChanged += MultiSelectComboBoxes_SelectedValuesChanged;

        }

        private async void BookReservationForm_Load(object? sender, EventArgs e)
        {

            var token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                await LoadBookFilterOptionsAsync();
                await LoadUserFilterOptionsAsync();
                await LoadStatusFilterOptions();
                await ShowBookReservationsAsync();
            }
            else
            {
                MessageBox.Show("No token found. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private async Task<string?> GetUserName(Guid userId)
        {
            using var client = ApiClientHelper.CreateClient();


            try
            {
                var response = await client.GetAsync("user");

                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var users = JsonSerializer.Deserialize<UserListResponse>(result, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    });
                    if (users != null)
                    {
                        var user = users.Value.FirstOrDefault(u => u.Id == userId);

                        return user?.UserName;
                    }
                    else
                    {
                        MessageBox.Show("No users found.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fetch users");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }

        private async Task LoadBookFilterOptionsAsync()
        {
            var options = await BookDropdownHelper.LoadBookOptionsAsync();

            if (options.Any())
            {
                booksMultiSelectComboBox.SetItems(options);
            }
        }

        private async Task LoadUserFilterOptionsAsync()
        {
            var options = await UserDropdownHelper.LoadUserOptionsAsync();

            if (options.Any())
            {
                usersMultiSelectComboBox.SetItems(options);
            }
        }

        private Task LoadStatusFilterOptions()
        {
            var options = new List<DropDownOption> {
        new DropDownOption { Label = "Issued", Value = "Issued" },
        new DropDownOption { Label = "Returned", Value = "Returned" }
    };

            if (options.Any())
            {
                statusMultiSelectComboBox.SetItems(options);
            }

            return Task.CompletedTask; // Ensure a Task is always returned
        }


        private async void MultiSelectComboBoxes_SelectedValuesChanged(object? sender, EventArgs e)
        {
            var selectedUserIds = usersMultiSelectComboBox
                .GetSelectedItems()
                .Select(opt => opt.Value.ToString())
                .ToList();

            var selectedBookIds = booksMultiSelectComboBox
                .GetSelectedItems()
                .Select(opt => opt.Value.ToString())
                .ToList();

            var selectedStatus = statusMultiSelectComboBox
                .GetSelectedItems()
                .Select(opt => opt.Value.ToString())
                .ToList();

            await ShowBookReservationsAsync(selectedUserIds, selectedBookIds, selectedStatus);
        }

        private async Task ShowBookReservationsAsync(List<string>? userIds = null, List<string>? bookIds = null, List<string>? statuses=null)
        {

            using var client = ApiClientHelper.CreateClient();

            try
            {
                var queryParts = new List<string>();
                if (userIds != null && userIds.Any())
                {
                    queryParts.AddRange(userIds.Select(id => $"userIds={id}"));
                }
                if (bookIds != null && bookIds.Any())
                {
                    queryParts.AddRange(bookIds.Select(id => $"bookIds={id}"));
                }
                if(statuses != null && statuses.Any())
                {
                    queryParts.AddRange(statuses.Select(status => $"statuses={statuses}"));
                }

                string url = "bookreservation";
                if (queryParts.Any())
                {
                    url += "?" + string.Join("&", queryParts);
                }

                var response = await client.GetAsync(url);
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
                        var tasks = bookReservations.Select(async bookReservation =>
                        {
                            var userName = await GetUserName(bookReservation.UserId);


                            return new BookReservationDisplayModal
                            {
                                Id = bookReservation.Id,
                                UserName = userName ?? "Unknown",
                                IssuedDate = bookReservation.IssuedDate,
                                DueDate = bookReservation.DueDate,
                                ReturnDate = bookReservation.ReturnDate,
                                Status = bookReservation.Status,
                                BookTitle = bookReservation?.Book?.Title,
                            };
                        });

                        var displayBookReservations = await Task.WhenAll(tasks);

                        BookReservationTableView.DataSource = displayBookReservations.ToList();

                    }

                }
            }
            catch (Exception ex) { }
        }

        private void addReservation_Click(object sender, EventArgs e)
        {
            AddReservationForm addReservationForm = new AddReservationForm();

            addReservationForm.Show();
        }


        private async void returnBook_Click(object sender, EventArgs e)
        {

            if (BookReservationTableView.CurrentRow?.DataBoundItem is BookReservationDisplayModal selectedReservation)
            {
                Guid reservationId = selectedReservation.Id;




                using var client = ApiClientHelper.CreateClient();
                try
                {
                    var payload = new List<Guid> { reservationId };
                    var response = await client.PostAsJsonAsync("BookReservation/return", payload);


                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Book returned successfully!");
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error: {response.StatusCode}\n{error}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }

            }

            else
            {
                MessageBox.Show("Failed to retrieve reservation data.");
            }
        }
    }
}
