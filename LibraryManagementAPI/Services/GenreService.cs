namespace LibraryManagementAPI.Services;

using DTOs;
using Interfaces;

public class GenreService
{
    private readonly IGenreRepository _genreRepository;

    public GenreService(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public async Task<List<GenreSummaryDto>> GetGenreIdNamesAsync()
    {
        return await _genreRepository.GetGenreIdNameAsync();
    }

}
