namespace RiverBooks.Books;

internal class BooksService : IBooksService
{
    public List<BookDto> ListBooks()
    {
        return
        [
            new BookDto(Guid.NewGuid(), "The fellowship of the ring", "J.R.R. Tolkien"),
            new BookDto(Guid.NewGuid(), "The two towers", "J.R.R. Tolkien"),
            new BookDto(Guid.NewGuid(), "The return of the king", "J.R.R. Tolkien")
        ];
    }
}