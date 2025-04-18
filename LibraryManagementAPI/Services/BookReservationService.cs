using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services;

public class BookReservationService
{
    private readonly IBookReservationRepository _bookReservationRepository;

    public BookReservationService(IBookReservationRepository bookReservationRepository)
    {
        _bookReservationRepository = bookReservationRepository;
    }

    public async Task<IEnumerable<BookReservation>> GetBookReservationsAsync(Guid? id = null)
    {
        return await _bookReservationRepository.GetBookReservationsAsync(id);
    }

    public async Task<BookReservation> AddBookReservationAsync(Guid bookId, Guid userId, DateTime dueDate)
    {
        return await _bookReservationRepository.AddBookReservationAsync(bookId, userId, dueDate);
    }

    public async Task UpdateBookReservationAsync(BookReservation bookReservation)
    {
        await _bookReservationRepository.UpdateBookReservationAsync(bookReservation);
    }
}
