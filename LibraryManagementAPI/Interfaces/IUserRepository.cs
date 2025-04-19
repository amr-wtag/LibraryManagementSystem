using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();
}
