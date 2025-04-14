// using LibraryManagementSystem.Winforms.Books;

namespace LibraryManagementSystem.Winforms.Models.Books;

public class Book
{
     public Guid Id { get; set; }
    public string? Title { get; set; }
    public int CopiesAvailable { get; set; }

    // public List<BookAuthor> BookAuthors { get; set; } = new();
    // public List<BookGenre> BookGenres { get; set; } = new();
}

