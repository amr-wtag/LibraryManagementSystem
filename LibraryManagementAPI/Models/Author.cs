namespace LibraryManagementAPI.Models;

public class Author : BaseEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public ICollection<BookAuthor>? BookAuthors { get; set; }
}
