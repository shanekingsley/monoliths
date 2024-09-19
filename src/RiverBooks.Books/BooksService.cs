namespace RiverBooks.Books;

internal class BooksService : IBooksService
{
    public List<BookDto> ListBooks()
    {
        return
        [
            new BookDto("2-55494-5484", "The fellowship of the ring", "J.R.R. Tolkien"),
            new BookDto("2-55494-5234", "The two towers", "J.R.R. Tolkien"),
            new BookDto("2-55425-3454", "The return of the king", "J.R.R. Tolkien")
        ];
    }
}