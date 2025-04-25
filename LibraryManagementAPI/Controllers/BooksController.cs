using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
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
        [FromQuery] Guid? id,
        [FromQuery] string? title, [FromQuery] string? author, [FromQuery] string? genre)
    {
        var books = await _bookService.GetFilteredBookAsync(id, title, author, genre);

        return Ok(books);
    }

    [HttpPost("create")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddBookAsync([FromBody] BookRequestDto dto)
    {
        var result = await _bookService.AddBookAsync(dto);
        return Ok(result);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateBookAsync(Guid id, [FromBody] BookRequestDto dto)
    {
        if (id != dto.Id)
        {
            return BadRequest("Book ID mismatch.");
        }

        try
        {
            var updatedBook = await _bookService.UpdateBookAsync(dto);
            return Ok(updatedBook);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }
}
