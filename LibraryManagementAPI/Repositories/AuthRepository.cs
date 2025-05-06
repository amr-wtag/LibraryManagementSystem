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
        if (string.IsNullOrWhiteSpace(user.Email))
        {
            return "Email is required.";
        }

        var existingUser = await _userManager.FindByEmailAsync(user.Email);
        if (existingUser != null)
        {
            return "Email is already registered.";
        }

        if (!AllowedRoles.Contains(role))
        {
            return "Invalid role specified.";
        }

        user.CreatedAt = DateTime.UtcNow;

        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
        {
            return string.Join(", ", result.Errors.Select(e => e.Description));
        }

        // Assign role (assuming roles already exist)
        await _userManager.AddToRoleAsync(user, role);

        return "User registered successfully";
    }

    public async Task<string?> LoginAsync(string identifier, string password)
    {
        var user = await _userManager.FindByNameAsync(identifier) ?? await _userManager.FindByEmailAsync(identifier);
        if (user == null)
        {
            return null;
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

        if (!result.Succeeded)
        {
            return null;
        }

        return await GenerateJwtToken(user);
    }

    public async Task Logout()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task<string> GenerateJwtToken(User user)
    {
        // Get the secret key from the environment variable
        var secretKey = Environment.GetEnvironmentVariable("JWT_SECRET");

        if (string.IsNullOrEmpty(secretKey))
        {
            throw new InvalidOperationException("JWT_SECRET environment variable is not set.");
        }

        // Create a list of claims based on user properties
        var claims = new List<Claim>
    {
        new(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new(ClaimTypes.Name, user.UserName?? string.Empty)
    };

        // Get the user's roles asynchronously and add them as claims
        var roles = await _userManager.GetRolesAsync(user);
        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role)); // Adding role as claim
        }

        // Generate the security key and signing credentials
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        // Create the JWT token
        var token = new JwtSecurityToken(
            _configuration["JwtSettings:Issuer"],
            _configuration["JwtSettings:Audience"],
            claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds
        );

        // Return the generated token as a string
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
