namespace LibraryManagementAPI.Models;

public class Transaction
{
    public Guid Id { get; set; }
    public int BookId { get; set; }
    public int MemberId { get; set; }
    public DateTime IssuedDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string Status { get; set; }
    
    public Book Book { get; set; }
    public Member Member { get; set; }
    
}
