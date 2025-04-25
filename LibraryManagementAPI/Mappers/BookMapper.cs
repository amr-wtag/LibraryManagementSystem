using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Mappers;

public static class BookMapper
{
    public static BookDto MapToDto(this Book book)
    {
        return new BookDto
        {
            Id = book.Id,
            Title = book.Title,
            CopiesAvailable = book.CopiesAvailable,
            Authors = book.BookAuthors?
                .Where(ba => ba.Author != null)
                .Select(ba => ba.Author!)
                .ToList() ?? new List<Author>(),
            Genres = book.BookGenres?
                .Where(bg => bg.Genre != null)
                .Select(bg => bg.Genre!)
                .ToList() ?? new List<Genre>()
        };
    }

    public static Book MapToEntity(this BookRequestDto dto)
    {
        return new Book
        {
            Title = dto.Title,
            CopiesAvailable = dto.CopiesAvailable,
            BookAuthors = dto.AuthorIds.Select(id => new BookAuthor { AuthorId = id }).ToList(),
            BookGenres = dto.GenreIds.Select(id => new BookGenre { GenreId = id }).ToList()
        };
    }
}
