using Microsoft.AspNetCore.Mvc;
using LibraryManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Controllers;

using Data;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly LibraryDbContext _context;

    public BookController(LibraryDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        try
        {
            return await _context.Books.ToListAsync();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred while retrieving books: {ex.Message}");
        }
    }
}
