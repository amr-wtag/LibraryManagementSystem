using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace LibraryManagementAPI.Repositories;

public class AuthRepository : IAuthRepository
{
    private static readonly string[] AllowedRoles = { "Admin", "Librarian", "User" };
    private readonly IConfiguration _configuration;
    private readonly RoleManager<Role> _roleManager;
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public AuthRepository(UserManager<User> userManager, SignInManager<User> signInManager,
        RoleManager<Role> roleManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _configuration = configuration;
    }

    public async Task<string> RegisterAsync(User user, string password, string role)
    {
        if (string.IsNullOrWhiteSpace(user.Email)) return "Email is required.";

        var existingUser = await _userManager.FindByEmailAsync(user.Email);
        if (existingUser != null) return "Email is already registered.";

        if (!AllowedRoles.Contains(role)) return "Invalid role specified.";

        user.CreatedAt = DateTime.UtcNow;

        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded) return string.Join(", ", result.Errors.Select(e => e.Description));

        // Assign role (assuming roles already exist)
        await _userManager.AddToRoleAsync(user, role);

        return "User registered successfully";
    }

    public async Task<string?> LoginAsync(string username, string email, string password)
    {
        var user = await _userManager.FindByNameAsync(username) ?? await _userManager.FindByEmailAsync(email);
        if (user == null) return null;

        var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

        if (!result.Succeeded) return null;
        return await GenerateJwtToken(user);
    }

    private async Task<string> GenerateJwtToken(User user)
    {
        var secretKey = _configuration["JwtSettings:Secret"]
                        ?? throw new InvalidOperationException("JWT Secret Key is missing in configuration.");

        var key = Encoding.UTF8.GetBytes(secretKey);

        // Get user roles
        var userRoles = await _userManager.GetRolesAsync(user);

        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),
            new(ClaimTypes.Name, user.UserName ?? string.Empty)
        };

        // Add role claims
        claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddHours(1),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
