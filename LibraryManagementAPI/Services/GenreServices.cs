namespace LibraryManagementAPI.Services;

using DTOs;
using Interfaces;

public class GenreServices
{
    private readonly IGenreRepository _genreRepository;

    public GenreServices(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public async Task<List<GenreSummaryDto>> GetGenreIdNamesAsync()
    {
        return await _genreRepository.GetGenreIdNamesAsync();
    }

}
