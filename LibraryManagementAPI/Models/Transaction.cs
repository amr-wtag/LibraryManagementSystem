namespace LibraryManagementAPI.Models;

public class Transaction
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime IssuedDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string? Status { get; set; }

    public Book? Book { get; set; }
    public MemberDetails? Member { get; set; }
}
