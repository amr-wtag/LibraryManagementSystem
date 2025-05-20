namespace LibraryManagementAPI.Controllers;

using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;

[Route("api/[controller]")]
[ApiController]
public class GenreController : ControllerBase
{
    private readonly GenreServices _genreServices;

    public GenreController(GenreServices genreServices)
    {
        _genreServices = genreServices;
    }


    [HttpGet("id-names")]
    public async Task<ActionResult<List<GenreSummaryDto>>> GetGenreIdNamesAsync()
    {
        var result = await _genreServices.GetGenreIdNamesAsync();

        return Ok(result);
    }
}
