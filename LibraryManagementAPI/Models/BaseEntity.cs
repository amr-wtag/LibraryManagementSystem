using LibraryManagementAPI.interfaces;

namespace LibraryManagementAPI.Models;

public abstract class BaseEntity : ITrackable
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
