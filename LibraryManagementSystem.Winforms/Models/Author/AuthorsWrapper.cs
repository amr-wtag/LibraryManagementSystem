namespace LibraryManagementSystem.Winforms.Models.Author
{
    public class AuthorsWrapper
    {
        [System.Text.Json.Serialization.JsonPropertyName("$values")]
        public List<Author>? Values { get; set; }
    }

}
