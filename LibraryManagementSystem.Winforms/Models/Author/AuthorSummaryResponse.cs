using LibraryManagementSystem.Winforms.Models.Author;

namespace LibraryManagementSystem.Winforms.Models.Books
{
    public class AuthorSummaryResponse
    {
        public List<AuthorSummary>? Values { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("$values")]
        public List<AuthorSummary>? RawValues { get => Values; set => Values = value; }
    }
}
