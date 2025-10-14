using System.Text.Json;
using LibraryManagementSystem.Winforms.helpers;
using LibraryManagementSystem.Winforms.Models.Users;

namespace LibraryManagementSystem.Winforms.dataHelpers;
public static class UserDropdownHelper
{
    public static async Task<List<DropDownOption>> LoadUserOptionsAsync()
    {
        using var client = ApiClientHelper.CreateClient();

        try
        {
            var response = await client.GetAsync("user/id-username");
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                // Show error message with status code and content
                MessageBox.Show(
                    $"Failed to load user list.\nStatus Code: {(int)response.StatusCode}\nDetails: {result}",
                    "API Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return new List<DropDownOption>();
            }

            var responseObject = JsonSerializer.Deserialize<UserSummaryResponse>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            var users = responseObject?.Values ?? new List<UserSummary>();

            return users.Select(user => new DropDownOption
            {
                Label = user.userName ?? "(Untitled)",
                Value = user.Id
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
