namespace LibraryManagementAPI.DTOs;

public class AddBookRequestDto
{
    public string Title { get; set; } = string.Empty;
    public int CopiesAvailable { get; set; }

    public List<Guid> AuthorIds { get; set; } = new();
    public List<Guid> GenreIds { get; set; } = new();
}
