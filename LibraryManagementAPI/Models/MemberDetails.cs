namespace LibraryManagementAPI.Models;

public class MemberDetails
{
    public Guid Id { get; set; }
    public String? Name { get; set; }
    public String? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public String? PhoneNumber { get; set; }
    public String? Address { get; set; }
    
    public ICollection<Transaction>? Transactions { get; set; }
    
    public string MemberId { get; set; }
    public Member? Member { get; set; }
    
}
