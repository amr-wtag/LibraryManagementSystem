namespace LibraryManagementSystem.Winforms.Models.Books
{
    public class BookSummaryResponse
    {
        public List<BookSummary>? Values { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("$values")]
        public List<BookSummary>? RawValues { get => Values; set => Values = value; }
    }
}
