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

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllUsersAsync();
    }

    public async Task<List<UserSummaryDto>> GetUserIdUserNameAsync()
    {
        return await _userRepository.GetUserIdUserNameAsync();
    }
}
