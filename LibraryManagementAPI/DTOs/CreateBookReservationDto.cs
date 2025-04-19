namespace LibraryManagementAPI.DTOs;

public class CreateBookReservationDto
{
    public Guid UserId { get; set; }
    public List<Guid> BookIds { get; set; } = new();
    public DateTime DueDate { get; set; }
}
