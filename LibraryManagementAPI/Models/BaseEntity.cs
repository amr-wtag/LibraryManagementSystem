using LibraryManagementAPI.interfaces;

namespace LibraryManagementAPI.Models;

public abstract class BaseEntity : ITrackable
{
    protected BaseEntity()
    {
        var now = DateTime.UtcNow;
        CreatedAt = now;
        UpdatedAt = now;
    }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
