
using LibraryManagementAPI.DTOs;

namespace LibraryManagementAPI.Interfaces;

public interface IGenreRepository
{
    public Task<List<GenreSummaryDto>> GetGenreIdNameAsync();
}
