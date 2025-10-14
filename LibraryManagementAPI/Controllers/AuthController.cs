using LibraryManagementAPI.Models;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] Register model)
    {
        var user = new User { UserName = model.UserName, Email = model.Email, FullName = model.FullName };
        var result = await _authService.RegisterAsync(user, model.Password, model.Role);

        if (result.Contains("User registered successfully"))
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Login model)
    {
        var token = await _authService.LoginAsync(model.identifier, model.Password);

        if (token == null)
        {
            return Unauthorized("invalid credentials");
        }

        return Ok(new { token });
    }

    [Authorize]
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        return Ok(new { message = "Logged out successfully" });
    }
}
