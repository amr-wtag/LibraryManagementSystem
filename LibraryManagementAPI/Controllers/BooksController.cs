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

    [HttpGet]
    public async Task<ActionResult<List<Book>>> GetFilteredBooksAsync(
        [FromQuery] string? title, [FromQuery] List<Guid>? bookIds, [FromQuery] List<Guid>? authorIds, [FromQuery] List<Guid>? genreIds)
    {
        var books = await _bookService.GetFilteredBookAsync(title, bookIds, authorIds, genreIds);

        return Ok(books);
    }

    [HttpPost]
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

    [HttpGet("id-titles")]
    public async Task<ActionResult<List<BookSummaryDto>>> GetBookIdTitlesAsync()
    {
        var result = await _bookService.GetBookIdTitleAsync();
        return Ok(result);
    }

}
