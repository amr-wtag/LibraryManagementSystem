using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync(Guid userId);

    Task<List<UserSummaryDto>> GetUserIdUserNameAsync();
}
