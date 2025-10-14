using LibraryManagementSystem.Winforms.Models.Author;

namespace LibraryManagementSystem.Winforms.Models.Books
{
    public class GenreSummaryResponse
    {
        public List<GenreSummery>? Values { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("$values")]
        public List<GenreSummery>? RawValues { get => Values; set => Values = value; }
    }
}
