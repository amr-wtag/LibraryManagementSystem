using System.Text.Json.Serialization;

namespace LibraryManagementAPI.Models;

public class Book : BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public int CopiesAvailable { get; set; }

    [JsonIgnore] public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    [JsonIgnore] public ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    [JsonIgnore] public ICollection<BookReservation>? BookReservations { get; set; }
}
