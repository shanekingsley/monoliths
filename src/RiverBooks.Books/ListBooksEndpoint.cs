using FastEndpoints;
namespace RiverBooks.Books;

internal class ListBooksEndpoint : EndpointWithoutRequest<ListBooksResponse>
{
    private readonly IBooksService _bookService;

    public ListBooksEndpoint(IBooksService bookService)
    {
        _bookService = bookService;
    }

    public override void Configure()
    {
        Get("/books");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync(new ListBooksResponse
        {
            Books = _bookService.ListBooks()
        }, cancellation: ct);
    }
}

internal class ListBooksResponse
{
    public List<BookDto> Books { get; set; } = [];
}