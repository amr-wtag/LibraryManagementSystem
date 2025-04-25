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

    public async Task<Book> AddBookAsync(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();

        return book;
    }

    public async Task<Book> UpdateBookAsync(Book book)
    {
        _context.Books.Update(book);
        await _context.SaveChangesAsync();

        return book;
    }

    public async Task<List<Book>> GetFilteredBookAsync(Guid? id, string? title, string? author, string? genre)
    {
        var query = _context.Books
            .Include(b => b.BookAuthors).ThenInclude(ba => ba.Author)
            .Include(b => b.BookGenres).ThenInclude(bg => bg.Genre)
            .AsQueryable();

        if (id.HasValue)
        {
            query = query.Where(b => b.Id == id.Value);
        }

        if (!string.IsNullOrWhiteSpace(title))
        {
            query = query.Where(b => b.Title!.ToLower().Contains(title.ToLower()));
        }

        if (!string.IsNullOrWhiteSpace(author))
        {
            query = query.Where(b => b.BookAuthors!.Any(ba =>
                ba.Author != null && ba.Author.Name!.ToLower().Contains(author.ToLower())));
        }

        if (!string.IsNullOrWhiteSpace(genre))
        {
            query = query.Where(b =>
                b.BookGenres!.Any(bg => bg.Genre != null && bg.Genre.Name!.ToLower().Contains(genre.ToLower())));
        }

        return await query.ToListAsync();
    }
}
