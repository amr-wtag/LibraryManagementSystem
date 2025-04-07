using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.interfaces;
using LibraryManagementAPI.Mappers;

namespace LibraryManagementAPI.Services;

public class BookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<BookDto>> GetFilteredBookAsync(string? title, string? author, string? genre)
    {
        var books = await _bookRepository.GetFilteredBookAsync(title, author, genre);
        return books.Select(book => book.MapToDto()).ToList();
    }

    public async Task<BookDto> AddBookAsync(AddBookRequestDto dto)
    {
        var bookEntity = dto.MapToEntity();
        var addBook = await _bookRepository.AddBookAsync(bookEntity);

        return addBook.MapToDto();
    }
}
