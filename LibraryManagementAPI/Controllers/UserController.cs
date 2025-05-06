using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [Authorize(Roles = "Admin,Librarian")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>>? GetAllUsers()
    {
        var users = await _userService.GetAllUsersAsync();
        return Ok(users);
    }

    [HttpGet("id-username")]
    public async Task<ActionResult<UserSummaryDto?>> GetUserIdUserNameAsync()
    {
        var result = await _userService.GetUserIdUserNameAsync();
        return Ok(result);
    }
}
