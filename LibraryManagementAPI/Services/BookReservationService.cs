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

    public async Task<IEnumerable<BookReservation>> GetBookReservationsAsync(List<Guid>? ids, List<Guid>? userIds,
        List<Guid>? bookIds, string status = "")
    {
        return await _bookReservationRepository.GetBookReservationsAsync(ids, userIds, bookIds, status);
    }

    public async Task<BookReservation> AddBookReservationAsync(Guid bookId, Guid userId, DateTime dueDate)
    {
        return await _bookReservationRepository.AddBookReservationAsync(bookId, userId, dueDate);
    }

    public async Task<List<BookReservation>> ReturnBooksAsync(List<Guid> reservationIds)
    {
        return await _bookReservationRepository.ReturnBooksAsync(reservationIds);
    }
}
