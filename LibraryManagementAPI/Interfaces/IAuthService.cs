namespace LibraryManagementAPI.interfaces;

using Models;

public interface IAuthService
{
    Task<string> RegisterAsync(User user, string password);
    Task<string?> LoginAsync(string username, string password);
}
