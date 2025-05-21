using LibraryManagementAPI.DTOs;

namespace LibraryManagementAPI.Interfaces;

    public interface IAuthorRepository
    {
        Task<List<AuthorSummaryDto>> GetAuthorIdTitleAsync();
    }

