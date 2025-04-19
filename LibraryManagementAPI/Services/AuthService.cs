using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services;

public class AuthService
{
    private readonly IAuthRepository _authRepository;

    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public async Task<string> RegisterAsync(User user, string password, string role)
    {
        return await _authRepository.RegisterAsync(user, password, role);
    }

    public async Task<string?> LoginAsync(string username, string email, string password)
    {
        return await _authRepository.LoginAsync(username, email, password);
    }

    public async Task Logout()
    {
        await _authRepository.Logout();
    }
}
