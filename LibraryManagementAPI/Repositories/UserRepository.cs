using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UserManager<User> _userManager;

    public UserRepository(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync(Guid userId)
    {
        var query = _userManager.Users.OrderBy(u => u.CreatedAt).AsQueryable();

        if (userId != Guid.Empty)
        {
            query = query.Where(u => u.Id == userId);
        }

        return await query.ToListAsync();
    }

    public async Task<List<UserSummaryDto>> GetUserIdUserNameAsync()
    {
        return await _userManager.Users.Select(u => new UserSummaryDto
        {
            Id = u.Id,
            UserName = u.UserName
        }).ToListAsync();
    }
}
