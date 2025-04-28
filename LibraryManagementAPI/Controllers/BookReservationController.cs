using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookReservationController : ControllerBase
{
    private readonly BookReservationService _bookReservationService;

    public BookReservationController(BookReservationService bookReservationService)
    {
        _bookReservationService = bookReservationService;
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Librarian")]
    public async Task<IActionResult> GetAllBookReservationsAsync(Guid? id = null, Guid? userId = null,
        Guid? bookId = null, string status = "")
    {
        var reservations = await _bookReservationService.GetBookReservationsAsync(id, userId, bookId, status);
        return Ok(reservations);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Librarian")]
    public async Task<IActionResult> AddBookReservationAsync([FromBody] CreateBookReservationDto dto)
    {
        try
        {
            var reservations = new List<BookReservation>();

            foreach (var item in dto.Reservations)
            {
                var reservation =
                    await _bookReservationService.AddBookReservationAsync(item.BookId, dto.UserId, item.DueDate);
                reservations.Add(reservation);
            }

            return Created("", reservations);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPost("return")]
    [Authorize(Roles = "Admin, Librarian")]
    public async Task<IActionResult> ReturnBooksAsync([FromBody] List<Guid> reservationIds)
    {
        try
        {
            var returnedBooks = await _bookReservationService.ReturnBooksAsync(reservationIds);
            return Ok(returnedBooks);
        }
        catch (Exception e)
        {
            return BadRequest(new { message = e.Message });
        }
    }
}
