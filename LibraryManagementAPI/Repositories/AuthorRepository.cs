using LibraryManagementAPI.Data;
using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryDbContext _context;

        public AuthorRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<List<AuthorSummaryDto>> GetAuthorIdTitleAsync()
        {
            return await _context.Books
                .Select(b => new AuthorSummaryDto
                {
                    Id = b.Id,
                    Title = b.Title
                })
                .ToListAsync();
        }
    }
}
