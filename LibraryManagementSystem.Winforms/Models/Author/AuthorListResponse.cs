using System.Text.Json.Serialization;

namespace LibraryManagementSystem.Winforms.Models.Author;

public class AuthorListResponse
{
    [JsonPropertyName("$values")]
    public List<Author> Value { get; set; } = new();
}
