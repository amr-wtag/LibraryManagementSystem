using System.Text.Json;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Books;

namespace LibraryManagementSystem.Winforms.dataHelpers;
public static class BookDropdownHelper
{
    public static async Task<List<DropDownOption>> LoadBookOptionsAsync()
    {
        var token = Properties.Settings.Default.JwtToken;

        using var client = ApiClientHelper.CreateClient();
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

        try
        {
            var response = await client.GetAsync("books/id-titles");
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                // Show error message with status code and content
                MessageBox.Show(
                    $"Failed to load book list.\nStatus Code: {(int)response.StatusCode}\nDetails: {result}",
                    "API Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return new List<DropDownOption>();
            }

            var responseObject = JsonSerializer.Deserialize<BookSummaryResponse>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            var books = responseObject?.Values ?? new List<BookSummary>();

            return books.Select(book => new DropDownOption
            {
                Label = book.Title ?? "(Untitled)",
                Value = book.Id
            }).ToList();
        }
        catch (HttpRequestException httpEx)
        {
            MessageBox.Show($"Network error occurred:\n{httpEx.Message}", "HTTP Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return new List<DropDownOption>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<DropDownOption>();
        }
    }
}
