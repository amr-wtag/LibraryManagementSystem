using Microsoft.AspNetCore.Mvc;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Controllers;

using Services;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly BookService _bookService;

    public BookController(BookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        var books = await _bookService.GetAllBooksAsync();
        return Ok(books);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Book>> GetBook(Guid id)
    {
        try
        {
            var book = await _bookService.GetBookByIdAsync(id);
            return Ok(book);

        }
        catch (KeyNotFoundException exception)
        {
            return NotFound(new { message = exception.Message });

        }


    }

    [HttpGet("by-author/{author}")]
    public async Task<ActionResult<List<Book>>> GetBookByAuthor(string author)
    {
        if (string.IsNullOrWhiteSpace(author))
        {
            return BadRequest("Author parameter cannot be empty.");
        }
        
        var books = await _bookService.GetBooksByAuthorAsync(author);
        
        if (books.Count == 0)
        {
            return NotFound("No books found for the given author.");
        }

        return Ok(books);
    }
}
