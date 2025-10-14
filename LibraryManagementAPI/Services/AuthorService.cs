using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Interfaces;

namespace LibraryManagementAPI.Services
{
    public class AuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public async Task<List<AuthorSummaryDto>> GetAuthorIdTitleAsync()
        {
            return await _authorRepository.GetAuthorIdTitleAsync();

        }
    }
}
