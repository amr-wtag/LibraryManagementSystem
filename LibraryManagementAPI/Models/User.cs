using LibraryManagementAPI.interfaces;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagementAPI.Models;

public class User : IdentityUser<Guid>, ITrackable
{
    public string? FullName { get; set; }

    public ICollection<BookReservation>? BookReservations { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
