namespace LibraryManagementAPI.Models;

public class Member
{
    public Guid Id { get; set; }
    public String? Name { get; set; }
    public String? Email { get; set; }
    public String? MembershipId { get; set; }
    
    public ICollection<Transaction>? Transactions { get; set; }
}
