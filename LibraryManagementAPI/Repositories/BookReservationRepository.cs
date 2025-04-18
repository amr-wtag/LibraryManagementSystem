using LibraryManagementAPI.Data;
using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Repositories;

public class BookReservationRepository : IBookReservationRepository
{
    private readonly LibraryDbContext _context;

    public BookReservationRepository(LibraryDbContext context)
    {
        _context = context;
    }


    public async Task UpdateBookReservationAsync(BookReservation bookReservation)
    {
        _context.BookReservations.Update(bookReservation);
        await _context.SaveChangesAsync();
    }

    public async Task<List<BookReservation>> GetBookReservationsAsync(Guid? id = null)
    {
        var query = _context.BookReservations
            .Include(r => r.Book)
            .Include(r => r.User);

        if (id.HasValue)
        {
            return await query.Where(r => r.Id == id.Value).ToListAsync();
        }

        return await query.ToListAsync();
    }

    public async Task<BookReservation> AddBookReservationAsync(Guid bookId, Guid userId, DateTime dueDate)
    {
        var existingReservation =
            await _context.BookReservations.Where(r => r.UserId == userId && r.BookId == bookId && r.Status == "Issued")
                .FirstOrDefaultAsync();

        if (existingReservation != null)
        {
            throw new Exception("User already has an active reservation for this book.");
        }

        var book = await _context.Books.FindAsync(bookId);
        if (book == null)
        {
            throw new Exception("Book not found");
        }

        if (book.CopiesAvailable <= 0)
        {
            throw new Exception("No copies available for reservation");
        }

        // Reduce the available copies
        book.CopiesAvailable--;

        var reservation = new BookReservation
        {
            Id = Guid.NewGuid(),
            BookId = bookId,
            UserId = userId,
            IssuedDate = DateTime.UtcNow,
            DueDate = dueDate,
            Status = "Issued",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        await _context.BookReservations.AddAsync(reservation);
        await _context.SaveChangesAsync();

        return reservation;
    }
}
