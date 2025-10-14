namespace LibraryManagementSystem.Winforms.Models.Genre
{
    public class GenreWrapper
    {
        [System.Text.Json.Serialization.JsonPropertyName("$values")]
        public List<Genre>? Values { get; set; }
    }

}
