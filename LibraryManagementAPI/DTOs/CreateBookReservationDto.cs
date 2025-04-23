namespace LibraryManagementAPI.DTOs;

public class CreateBookReservationDto
{
    public Guid UserId { get; set; }

    public List<BookReservationItemDto> Reservations { get; set; } = new();
}

public class BookReservationItemDto
{
    public Guid BookId { get; set; }
    public DateTime DueDate { get; set; }
}
