namespace LibraryManagementAPI.interfaces;

using Models;

public class IAuthRepository
{
    Task<string> RegisterAsync(User user, string password);
    Task<string?> LoginAsync(string username, string password);
}
