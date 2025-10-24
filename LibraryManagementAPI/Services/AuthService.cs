using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;
using Microsoft.IdentityModel.Tokens;

namespace LibraryManagementAPI.Services;

public class AuthService
{
    private readonly IAuthRepository _authRepository;
    private readonly string _secret;

    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
        _secret = Environment.GetEnvironmentVariable("JWT_SECRET") ?? throw new Exception("JWT_SECRET environment variable is not set");
    }

    public string Secret => _secret;

    public async Task<string> RegisterAsync(User user, string password, string role)
    {
        return await _authRepository.RegisterAsync(user, password, role);
    }

    public async Task<string?> LoginAsync(string identifier, string password)
    {
        return await _authRepository.LoginAsync(identifier, password);
    }

    public async Task Logout()
    {
        await _authRepository.Logout();
    }

    public MeResponse ValidateToken(string token)
{
    var tokenHandler = new JwtSecurityTokenHandler();
    var key = Encoding.ASCII.GetBytes(Secret);

    var validationParams = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = false,
        ClockSkew = TimeSpan.Zero
    };

    try
    {
        var principal = tokenHandler.ValidateToken(token, validationParams, out SecurityToken validatedToken);


        if (validatedToken is JwtSecurityToken jwtToken && jwtToken.ValidTo < DateTime.UtcNow)
        {
            throw new SecurityTokenExpiredException("Token has expired.");
        }

        var userIdClaim = principal.Claims.FirstOrDefault(c =>
            c.Type == ClaimTypes.NameIdentifier ||
            c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"
        )?.Value;

        var userNameClaim = principal.Claims.FirstOrDefault(c =>
            c.Type == ClaimTypes.Name ||
            c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"
        )?.Value;

        var roleClaim = principal.Claims.FirstOrDefault(c =>
            c.Type == ClaimTypes.Role ||
            c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
        )?.Value;

        if (userIdClaim == null || userNameClaim == null)
            throw new Exception("Token missing required claims");

        return new MeResponse
        {
            Id = Guid.Parse(userIdClaim),
            UserName = userNameClaim,
            Role = roleClaim
        };
    }
    catch (SecurityTokenExpiredException)
    {

        throw new UnauthorizedAccessException("Token expired. Please log in again.");
    }
    catch (Exception ex)
    {

        throw new UnauthorizedAccessException($"Invalid token: {ex.Message}");
    }
}

}
