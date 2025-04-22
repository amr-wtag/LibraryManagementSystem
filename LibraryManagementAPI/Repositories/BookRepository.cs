using LibraryManagementAPI.Data;
using LibraryManagementAPI.DTOs;
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

    public async Task<List<Book>> GetFilteredBookAsync(string? title, List<Guid>? bookIds, List<Guid>? authorIds, List<Guid>? genreIds)
    {
        var query = _context.Books
            .Include(b => b.BookAuthors).ThenInclude(ba => ba.Author)
            .Include(b => b.BookGenres).ThenInclude(bg => bg.Genre)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(title))
        {
            query = query.Where(b => b.Title!.ToLower().Contains(title.ToLower()));
        }

        if (bookIds != null && bookIds.Any())
        {
            query = query.Where(b => bookIds.Contains(b.Id));
        }

        if (authorIds != null && authorIds.Any())
        {
            query = query.Where(b => b.BookAuthors!.Any(ba =>
                ba.Author != null && authorIds.Contains(ba.Author.Id)));
        }

        if (genreIds != null && genreIds.Any())
        {
            query = query.Where(b => b.BookGenres!.Any(
                bg => bg.Genre != null && genreIds.Contains(bg.Genre.Id)));
        }

        return await query.ToListAsync();
    }

    public async Task<Book> AddBookAsync(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return book;
    }

    public async Task<List<BookSummaryDto>> GetBookIdTitleAsync()
    {
        return await _context.Books
            .Select(b => new BookSummaryDto
            {
                Id = b.Id,
                Title = b.Title
            })
            .ToListAsync();
    }

}
