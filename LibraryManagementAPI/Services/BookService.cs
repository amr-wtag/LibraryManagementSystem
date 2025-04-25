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

    public async Task<List<BookDto>> GetFilteredBookAsync(Guid? id, string? title, string? author, string? genre)
    {
        var books = await _bookRepository.GetFilteredBookAsync(id, title, author, genre);
        return books.Select(book => book.MapToDto()).ToList();
    }

    public async Task<BookDto> AddBookAsync(BookRequestDto dto)
    {
        var bookEntity = dto.MapToEntity();
        var addBook = await _bookRepository.AddBookAsync(bookEntity);

        return addBook.MapToDto();
    }

    public async Task<BookDto> UpdateBookAsync(BookRequestDto dto)
    {
        var existingBook = await _bookRepository.GetFilteredBookAsync(dto.Id, null, null, null);
        if (existingBook == null || !existingBook.Any())
        {
            throw new Exception("Book not found");
        }

        var bookEntity = dto.MapToEntity();
        var updateBook = existingBook.First();

        updateBook.Title = dto.Title;
        updateBook.CopiesAvailable = dto.CopiesAvailable;
        updateBook.BookAuthors = bookEntity.BookAuthors;
        updateBook.BookGenres = bookEntity.BookGenres;

        var updatedBook = await _bookRepository.UpdateBookAsync(updateBook);

        return updatedBook.MapToDto();
    }
}
