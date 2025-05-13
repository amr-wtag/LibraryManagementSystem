namespace LibraryManagementSystem.Winforms.Models.Books;

public class BookDisplayModel
{
    public string Title { get; set; } = string.Empty;
    public int CopiesAvailable { get; set; }
    public string Authors { get; set; } = string.Empty;

    public List<Guid>? AuthorIds { get; set; }
    public string Genres { get; set; } = string.Empty;
}
