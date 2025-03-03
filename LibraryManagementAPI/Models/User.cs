using Microsoft.AspNetCore.Identity;

namespace LibraryManagementAPI.Models;

public class User: IdentityUser
{
 public string? fullName { get; set; }
}
