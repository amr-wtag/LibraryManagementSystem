namespace LibraryManagementAPI.Repositories;

using interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

public class BookRepository : IBookRepository
{
    private readonly LibraryDbContext _context;

    public BookRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        return await _context.Books.ToListAsync();
    }

    public async Task<Book?> GetBookByIdAsync(Guid id)
    {
        return await _context.Books.FindAsync(id);
    }

    public async Task<List<Book>> GetBooksByAuthorAsync(string? author)
    {
        return await _context.Books
            .Where(book => !string.IsNullOrEmpty(book.Author) &&
                           (author == null || book.Author.ToLower().Contains(author.ToLower())))
            .ToListAsync();
    }
}
