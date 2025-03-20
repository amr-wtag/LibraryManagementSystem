namespace LibraryManagementAPI.interfaces;

using Models;

public interface IAuthRepository
{
    Task<string> RegisterAsync(User user, string password);
    Task<string?> LoginAsync(string username, string email, string password);
}
