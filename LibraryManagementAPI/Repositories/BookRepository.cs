using LibraryManagementAPI.Data;
using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Repositories;

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
            .Where(book => book.BookAuthors!.Any(ba =>
                ba.Author != null && (author == null || ba.Author.Name.ToLower().Contains(author.ToLower()))))
            .ToListAsync();
    }
}
