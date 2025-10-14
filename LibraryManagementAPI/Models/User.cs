using System.ComponentModel.DataAnnotations;
using LibraryManagementAPI.interfaces;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagementAPI.Models;

public class User : IdentityUser<Guid>, ITrackable
{
    public User()
    {
        MembershipId ??= GenerateMembershipId();
    }

    private string GenerateMembershipId()
    {
        // Example: "MBR-20250608-XYZ123"
        return $"MBR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..6].ToUpper()}";
    }

    [Required]
    [MaxLength(50)]
    public string? MembershipId { get; set; }
    [MaxLength(100)]
    public string? FullName { get; set; }

    public ICollection<BookReservation>? BookReservations { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
