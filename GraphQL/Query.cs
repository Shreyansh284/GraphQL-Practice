using graphql.Models;

namespace graphql.GraphQL;

public class Query
{
    public IEnumerable<Book> GetBooks() =>
        new List<Book>
        {
            new(1, "Clean Code", "Robert C. Martin"),
            new(2, "The Pragmatic Programmer", "Andrew Hunt")
        };
}