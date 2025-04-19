using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Tests.Models;

public class BookGenreTests
{
    [Fact]
    public void BookGenre_ShouldHaveDefaultValues()
    {
        var bookGenre = new BookGenre();


        Assert.Equal(Guid.Empty, bookGenre.BookId);
        Assert.Equal(Guid.Empty, bookGenre.GenreId);
        Assert.Null(bookGenre.Book);
        Assert.Null(bookGenre.Genre);
    }

    [Fact]
    public void BookGenre_ShouldHaveNonEmptyGuidOnCreation()
    {
        var bookGenre = new BookGenre { BookId = Guid.NewGuid(), GenreId = Guid.NewGuid() };


        Assert.NotEqual(Guid.Empty, bookGenre.BookId);
        Assert.NotEqual(Guid.Empty, bookGenre.GenreId);
    }

    [Fact]
    public void BookGenre_Relationship_ShouldBeSetCorrectly()
    {
        var book = new Book();
        var genre = new Genre();
        var bookGenre = new BookGenre
        {
            BookId = book.Id,
            GenreId = genre.Id,
            Book = book,
            Genre = genre
        };


        Assert.Equal(book.Id, bookGenre.BookId);
        Assert.Equal(genre.Id, bookGenre.GenreId);
        Assert.Same(book, bookGenre.Book);
        Assert.Same(genre, bookGenre.Genre);
    }
}
