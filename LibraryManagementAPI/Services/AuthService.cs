namespace LibraryManagementAPI.Services;

using interfaces;
using Models;

public class AuthService: IAuthService
{
    private readonly IAuthService _authService;

    public AuthService(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<string> RegisterAsync(User user, string password)
    {
        return await _authService.RegisterAsync(user, password);
    }

    public async Task<string?> LoginAsync(string username, string password)
    {
        return await _authService.LoginAsync(username, password);
    }

}
