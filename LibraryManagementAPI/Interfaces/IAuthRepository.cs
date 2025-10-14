using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IAuthRepository
{
    Task<string> RegisterAsync(User user, string password, string role);
    Task<string?> LoginAsync(string identifier, string password);
    Task Logout();
}
