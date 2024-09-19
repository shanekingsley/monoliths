using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace RiverBooks.Books;

public static class BookEndpoints
{
    public static void MapBookEndpoints(this WebApplication app)
    {
        app.MapGet("/books", (IBooksService bookService) => { return bookService.ListBooks(); })
            .WithName("GetBooks");
    }
}

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBookServices(this IServiceCollection services)
    {
        return services.AddTransient<IBooksService, BooksService>();
    }
}

public record BookDto(string Isbn, string Title, string Author);

internal interface IBooksService
{
    IEnumerable<BookDto> ListBooks();
}

internal class BooksService : IBooksService
{
    public IEnumerable<BookDto> ListBooks()
    {
        return
        [
            new BookDto("2-55494-5484", "The fellowship of the ring", "J.R.R. Tolkien"),
            new BookDto("2-55494-5234", "The two towers", "J.R.R. Tolkien"),
            new BookDto("2-55425-3454", "The return of the king", "J.R.R. Tolkien")
        ];
    }
}