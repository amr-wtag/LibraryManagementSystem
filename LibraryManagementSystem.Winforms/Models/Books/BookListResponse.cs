using System.Text.Json.Serialization;

namespace LibraryManagementSystem.Winforms.Models.Books;

public class BookListResponse
{
    [JsonPropertyName("$values")]
    public List<Book> Value { get; set; } = new();

}
