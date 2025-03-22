namespace LibraryManagementAPI.Services;

using interfaces;
using Models;

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
}
