namespace LibraryManagementAPI.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Models;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IConfiguration _configuration;

    public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
    }

    public async Task<string> RegisterAsync(User user, string password)
    {
        if (string.IsNullOrWhiteSpace(user.Email))
        {
            return "Email is required.";
        }

        var existingUser = await _userManager.FindByEmailAsync(user.Email);
        if (existingUser != null)
        {
            return "Email is already registered.";
        }

        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
        {
            return string.Join(", ", result.Errors.Select(e => e.Description));
        }

        return "User registered successfully.";
    }

    public async Task<string?> LoginAsync(string username, string email, string password)
    {
        var user = await _userManager.FindByNameAsync(username) ?? await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return null;
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

        if (!result.Succeeded) return null;
        return GenerateJwtToken(user);
    }

    public string GenerateJwtToken(User user)
    {
        var secretKey = _configuration["JwtSettings:Secret"]
                        ?? throw new InvalidOperationException("JWT Secret Key is missing in configuration.");

        var key = Encoding.UTF8.GetBytes(secretKey);
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),
            new Claim(ClaimTypes.Name, user.UserName ?? string.Empty)
        };

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddHours(1),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
