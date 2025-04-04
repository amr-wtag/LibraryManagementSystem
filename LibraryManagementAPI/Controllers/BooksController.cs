using LibraryManagementAPI.Models;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly BookService _bookService;

    public BooksController(BookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("filter")]
    public async Task<ActionResult<List<Book>>> GetFilteredBooksAsync(
        [FromQuery] string? title, [FromQuery] string? author, [FromQuery] string? genre)
    {
        var books = await _bookService.GetFilteredBookAsync(title, author, genre);

        return Ok(books);
    }
}
