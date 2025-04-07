using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IBookRepository
{
    Task<List<Book>> GetFilteredBookAsync(string? title, string? author, string? genre);
    Task<Book> AddBookAsync(Book book);
}
