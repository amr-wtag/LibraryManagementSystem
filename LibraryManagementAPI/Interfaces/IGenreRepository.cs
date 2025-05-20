namespace LibraryManagementAPI.Interfaces;

using DTOs;

public interface IGenreRepository
{
    public Task<List<GenreSummaryDto>> GetGenreIdNamesAsync();
}
