namespace LibraryManagementAPI.Controllers;

using interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] Register model)
    {
        var user = new User { UserName = model.UserName, Email = model.Email, FullName = model.FullName };
        var result = await _authService.RegisterAsync(user, model.Password);
        if (result.Contains("User registered successfully"))
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Login model)
    {
        var token = await _authService.LoginAsync(model.UserName, model.Email, model.Password);

        if (token == null)
        {
            return Unauthorized("invalid credentials");
        }

        return Ok(token);
    }
}
