using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IBookRepository
{
    Task<List<Book>> GetFilteredBookAsync(string? title, List<Guid>? bookIds, List<Guid>? authorIds, List<Guid>? genreIds);
    Task<Book> AddBookAsync(Book book);
    Task<Book> UpdateBookAsync(Book book);

    Task<List<BookSummaryDto>> GetBookIdTitleAsync();
}
