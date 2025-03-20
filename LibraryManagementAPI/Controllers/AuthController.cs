namespace LibraryManagementAPI.Controllers;

using interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthRepository _authRepository;

    public AuthController(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] Register model)
    {
        var user = new User { UserName = model.UserName, Email = model.Email, FullName = model.FullName };
        var result = await _authRepository.RegisterAsync(user, model.Password);
        if (result.Contains("User registered successfully"))
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Login model)
    {
        var token = await _authRepository.LoginAsync(model.UserName, model.Email, model.Password);

        if (token == null)
        {
            return Unauthorized("invalid credentials");
        }

        return Ok(token);
    }
}
