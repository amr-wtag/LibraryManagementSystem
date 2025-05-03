using System.Text.Json.Serialization;

namespace LibraryManagementSystem.Winforms.Models.Users
{
    public class UserSummaryResponse
    {
        [JsonPropertyName("$values")]
        public List<UserSummary> Values { get; set; } = new();
    }
}
