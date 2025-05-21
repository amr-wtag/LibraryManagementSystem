
using System.Text.Json.Serialization;

namespace LibraryManagementSystem.Winforms.Models.Users;

    public class UserListResponse
    {
        [JsonPropertyName("$values")]
        public List<User> Value { get; set; } = new();
    }

