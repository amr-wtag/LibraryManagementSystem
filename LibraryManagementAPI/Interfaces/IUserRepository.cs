using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();

    Task<List<UserSummaryDto>> GetUserIdUserNameAsync();
}
