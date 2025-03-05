using Microsoft.AspNetCore.Identity;

namespace LibraryManagementAPI.Models;

public class Member: IdentityUser
{
    public string? MembershipId { get; set; }
}
