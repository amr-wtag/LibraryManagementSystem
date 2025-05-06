using System.Text.Json.Serialization;

namespace LibraryManagementSystem.Winforms.Models;

public class LoginResponse
{
    [JsonPropertyName("token")]
    public string? Token { get; set; }
    // public int ExpiresIn { get; set; }
}