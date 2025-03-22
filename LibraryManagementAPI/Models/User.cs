using Microsoft.AspNetCore.Identity;

namespace LibraryManagementAPI.Models;

public class User : IdentityUser<Guid>
{
    public string? FullName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Transaction>? Transactions { get; set; }
}
