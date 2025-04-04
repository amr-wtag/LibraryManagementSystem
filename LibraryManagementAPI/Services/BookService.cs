using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services;

public class BookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<Book>> GetFilteredBookAsync(string? title, string? author, string? genre)
    {
        return await _bookRepository.GetFilteredBookAsync(title, author, genre);
    }
}
