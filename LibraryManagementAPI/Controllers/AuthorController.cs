using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }


        [HttpGet("id-titles")]
        public async Task<ActionResult<List<AuthorSummaryDto>>> GetAuthoeIdTitlesAsync()
        {
            var result = await _authorService.GetAuthorIdTitleAsync();
            return Ok(result);
        }
    }
}
