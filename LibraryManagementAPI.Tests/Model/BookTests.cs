using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Tests.Models;

public class BookTests
{
    [Fact]
    public void Book_ShouldHaveDefaultValues()
    {
        var book = new Book();

        Assert.NotEqual(Guid.Empty, book.Id);
        Assert.Empty(book.BookAuthors);
        Assert.Empty(book.BookGenres);
        Assert.Null(book.BookReservations);
    }

    [Fact]
    public void Book_CreatedAt_ShouldBeSetOnCreation()
    {
        var before = DateTime.UtcNow;
        var book = new Book();
        var after = DateTime.UtcNow;

        Assert.InRange(book.CreatedAt, before, after);
    }

    [Fact]
    public void Book_UpdatedAt_ShouldBeSetOnCreation()
    {
        var before = DateTime.UtcNow;
        var book = new Book();
        var after = DateTime.UtcNow;

        Assert.InRange(book.UpdatedAt, before, after);
    }

    [Fact]
    public void Book_Title_ShouldBeSetCorrectly()
    {
        var book = new Book();
        var title = "Test Book";

        book.Title = title;

        Assert.Equal(title, book.Title);
    }

    [Fact]
    public void Book_CopiesAvailable_ShouldBeSetCorrectly()
    {
        var book = new Book();
        var copiesAvailable = 10;

        book.CopiesAvailable = copiesAvailable;

        Assert.Equal(copiesAvailable, book.CopiesAvailable);
    }

    [Fact]
    public void Book_ShouldInitializeBookAuthors()
    {
        var book = new Book();

        Assert.NotNull(book.BookAuthors);
    }

    [Fact]
    public void Book_ShouldInitializeBookGenres()
    {
        var book = new Book();

        Assert.NotNull(book.BookGenres);
    }
}
