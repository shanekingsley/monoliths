using Microsoft.Extensions.DependencyInjection;

namespace RiverBooks.Books;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBookServices(this IServiceCollection services)
    {
        return services.AddTransient<IBooksService, BooksService>();
    }
}