using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IBookReservationRepository
{
    Task<List<BookReservation>> GetBookReservationsAsync(List<Guid>? ids, List<Guid>? userIds, List<Guid>? bookIds,
        string status = "");

    Task<BookReservation> AddBookReservationAsync(Guid bookId, Guid userId, DateTime dueDate);
    Task<List<BookReservation>> ReturnBooksAsync(List<Guid> reservationIds);
}
