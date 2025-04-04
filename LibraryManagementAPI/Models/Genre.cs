namespace LibraryManagementAPI.Models;

public class Genre
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = string.Empty;

    public ICollection<BookGenre>? BookGenres { get; set; } = new List<BookGenre>();
}
