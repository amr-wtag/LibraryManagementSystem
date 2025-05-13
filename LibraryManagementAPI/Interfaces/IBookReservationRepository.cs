using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IBookReservationRepository
{
    Task<List<BookReservation>> GetBookReservationsAsync(Guid? id = null, Guid? userId = null, Guid? bookId = null,
        string status = "");

    Task<BookReservation> AddBookReservationAsync(Guid bookId, Guid UserId, DateTime dueDate);
    Task<List<BookReservation>> ReturnBooksAsync(List<Guid> reservationIds);
}
