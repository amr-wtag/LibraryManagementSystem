using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Tests.Models;

public class AuthorTests
{
    [Fact]
    public void Author_Can_Be_Created()
    {
        var id = new Guid();
        var name = "John";

        var authoe = new Author()
        {
            Id = id,
            Name = name
        };
        
        Assert.Equal(id, authoe.Id);    
        Assert.Equal(name, authoe.Name);
        Assert.Null(authoe.BookAuthors);
    }

    [Fact]
    public void Can_Assign_Author_To_BookAuthors()
    {
        var bookAuthors = new List<BookAuthor>
        {
            new BookAuthor { BookId = Guid.NewGuid(), AuthorId = Guid.NewGuid() },
        };

        var author = new Author
        {
            Id = Guid.NewGuid(),
            Name = "John",
            BookAuthors = bookAuthors

        };
        
        Assert.NotNull(author.BookAuthors);
        Assert.Single(author.BookAuthors);
    }
}

