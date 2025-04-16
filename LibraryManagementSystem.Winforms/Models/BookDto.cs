namespace LibraryManagementSystem.Winforms.Models;

public class BookDto
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int CopiesAvailable { get; set; }
    public List<GenreDto> Genres { get; set; } = new();
    public List<AuthorDto> Authors { get; set; } = new();
}