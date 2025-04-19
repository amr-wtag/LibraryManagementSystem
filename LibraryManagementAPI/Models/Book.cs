namespace LibraryManagementAPI.Models;

public class Book : BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public int CopiesAvailable { get; set; }

    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    public ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    public ICollection<BookReservation>? BookReservations { get; set; }
}
 