namespace LibraryManagementAPI.Models;

using Microsoft.AspNetCore.Identity;

public class Member: IdentityUser<Guid>
{
    public String? MembershipId { get; set; }

    public ICollection<Transaction>? Transactions { get; set; }
}
