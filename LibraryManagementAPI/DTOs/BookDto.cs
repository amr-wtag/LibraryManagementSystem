using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.DTOs;

public class BookDto
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int CopiesAvailable { get; set; }

    public List<Genre> Genres { get; set; } = new();
    public List<Author> Authors { get; set; } = new();
}
