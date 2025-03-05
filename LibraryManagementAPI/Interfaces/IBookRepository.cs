namespace LibraryManagementAPI.interfaces;

using Models;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetAllBooksAsync();
    Task<Book?> GetBookByIdAsync(Guid id);
    Task<List<Book>> GetBooksByAuthorAsync(string? author);
}
