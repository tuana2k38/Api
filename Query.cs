public class Query {
    public Task<List<Book>> GetBooks([Service] Repository repository) =>
         repository.GetBooksAsync();
    public string GetHello() => "World";
    public Book Gettemp() => new Book(new Guid(), "title book", new Author(new Guid(), "Huy Tuan"));
}