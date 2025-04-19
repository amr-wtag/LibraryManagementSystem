namespace LibraryManagementAPI.Models;

public class Book
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Category { get; set; }
    public int CopiesAvailable { get; set; }

    public ICollection<BookReservation>? BookReservations { get; set; }
}
