using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IAuthRepository
{
    Task<string> RegisterAsync(User user, string password, string role);
    Task<string?> LoginAsync(string username, string email, string password);
    Task Logout();
}
