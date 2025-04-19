namespace LibraryManagementAPI.Models;

public class BookReservation
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid UserId { get; set; }

    public DateTime IssuedDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string? Status { get; set; }

    public Book? Book { get; set; }

    public User? User { get; set; }
}
