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

    public async Task<string?> LoginAsync(string identifier, string password)
    {
        return await _authRepository.LoginAsync(identifier, password);
    }

    public async Task Logout()
    {
        await _authRepository.Logout();
    }
}
