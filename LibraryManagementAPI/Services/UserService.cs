using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync(Guid userId)
    {
        return await _userRepository.GetAllUsersAsync(userId);
    }

    public async Task<List<UserSummaryDto>> GetUserIdUserNameAsync()
    {
        return await _userRepository.GetUserIdUserNameAsync();
    }
}
