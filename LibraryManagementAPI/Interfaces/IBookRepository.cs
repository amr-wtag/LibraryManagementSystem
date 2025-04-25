using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IBookRepository
{
    Task<List<Book>> GetFilteredBookAsync(Guid? id, string? title, string? author, string? genre);
    Task<Book> AddBookAsync(Book book);
    Task<Book> UpdateBookAsync(Book book);
}
