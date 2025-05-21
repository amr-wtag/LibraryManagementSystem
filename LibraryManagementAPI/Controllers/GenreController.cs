namespace LibraryManagementAPI.Controllers;

using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;

[Route("api/[controller]")]
[ApiController]
public class GenreController : ControllerBase
{
    private readonly GenreService _genreService;

    public GenreController(GenreService genreService)
    {
        _genreService = genreService;
    }


    [HttpGet("id-names")]
    public async Task<ActionResult<List<GenreSummaryDto>>> GetGenreIdNamesAsync()
    {
        var result = await _genreService.GetGenreIdNamesAsync();

        return Ok(result);
    }
}
