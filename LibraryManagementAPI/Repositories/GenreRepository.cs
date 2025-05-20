namespace LibraryManagementAPI.Repositories;

using Data;
using DTOs;
using Interfaces;
using Microsoft.EntityFrameworkCore;

public class GenreRepository: IGenreRepository
{
    private readonly LibraryDbContext _context;

    public GenreRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<List<GenreSummaryDto>> GetGenreIdNameAsync()
    {
        return await _context.Genres.Select(g => new GenreSummaryDto
        {
            Id = g.Id,
            Name = g.Name
        }).ToListAsync();
    }
}
