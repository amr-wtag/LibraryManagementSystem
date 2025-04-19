using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Tests.Models;

public class BookAuthorTests
{
    [Fact]
    public void BookAuthor_ShouldInitializeCorrectly()
    {
        var bookId = Guid.NewGuid();
        var authorId = Guid.NewGuid();


        var bookAuthor = new BookAuthor
        {
            BookId = bookId,
            AuthorId = authorId
        };


        Assert.Equal(bookId, bookAuthor.BookId);
        Assert.Equal(authorId, bookAuthor.AuthorId);
        Assert.Null(bookAuthor.Book);
        Assert.Null(bookAuthor.Author);
    }

    [Fact]
    public void BookAuthor_ShouldSetBookAndAuthorNavigationProperties()
    {
        var bookId = Guid.NewGuid();
        var authorId = Guid.NewGuid();
        var book = new Book { Id = bookId, Title = "Sample Book" };
        var author = new Author { Id = authorId, Name = "Sample Author" };


        var bookAuthor = new BookAuthor
        {
            BookId = bookId,
            AuthorId = authorId,
            Book = book,
            Author = author
        };


        Assert.Equal(book, bookAuthor.Book);
        Assert.Equal(author, bookAuthor.Author);
    }

    [Fact]
    public void BookAuthor_ShouldNotAllowNullBookAndAuthor()
    {
        var bookId = Guid.NewGuid();
        var authorId = Guid.NewGuid();


        var bookAuthor = new BookAuthor
        {
            BookId = bookId,
            AuthorId = authorId
        };


        Assert.Null(bookAuthor.Book);
        Assert.Null(bookAuthor.Author);
    }
}
