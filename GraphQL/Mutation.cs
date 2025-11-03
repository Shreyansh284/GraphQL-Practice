using graphql.Models;

namespace graphql.GraphQL;

public class Mutation
{
    private static List<Book> _books = new()
    {
        new(1, "Clean Code", "Robert C. Martin")
    };

    public Book AddBook(string title, string author)
    {
        var book = new Book(_books.Count + 1, title, author);
        _books.Add(book);
        return book;
    }
}