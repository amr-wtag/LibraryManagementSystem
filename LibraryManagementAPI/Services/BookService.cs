namespace LibraryManagementAPI.Services;

using interfaces;
using Models;

public class BookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        return await _bookRepository.GetAllBooksAsync();
    }

    public async Task<Book?> GetBookByIdAsync(Guid id)
    {
        return await _bookRepository.GetBookByIdAsync(id);
    }

    public async Task<List<Book>> GetBooksByAuthorAsync(string? author)
    {
        return await _bookRepository.GetBooksByAuthorAsync(author);
    }
}
