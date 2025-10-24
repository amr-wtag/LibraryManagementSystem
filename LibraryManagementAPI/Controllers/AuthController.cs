using System.IdentityModel.Tokens.Jwt;
using System.Text;
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



        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Secure = true, // local dev
            SameSite = SameSiteMode.None, // allow cross-origin
            Expires = DateTimeOffset.Now.AddDays(7),
            Path = "/"
        };


        Response.Cookies.Append("token", token, cookieOptions);

        return Ok(new { token, message = "Login successful" });
    }

    [Authorize]
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        return Ok(new { message = "Logged out successfully" });
    }

    [HttpGet("me")]
    public IActionResult Me()
    {
        // 1. Try Authorization header first
        var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

        // 2. Fallback to cookie
        if (string.IsNullOrEmpty(token))
        {
            token = Request.Cookies["token"];
        }

        if (string.IsNullOrEmpty(token))
            return Unauthorized("Token missing");

        try
        {
            var user = _authService.ValidateToken(token);
            return Ok(user);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

}
