// using LibraryManagementSystem.Winforms.Books;

using LibraryManagementSystem.Winforms.Models.Author;
using LibraryManagementSystem.Winforms.Models.Genre;

namespace LibraryManagementSystem.Winforms.Models.Books;

public class Book
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int CopiesAvailable { get; set; }

    public AuthorsWrapper? Authors { get; set; }
    public GenreWrapper? Genres { get; set; }
    // public List<BookGenre> BookGenres { get; set; } = new();
}

