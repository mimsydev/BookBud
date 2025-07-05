namespace BookBud.Server.BookProvider
{
    public interface IBookProviderService<T> where T : IProvidedBook
    {
        public Task<List<T>> GetBooks(string query);
        public Task<T> GetBook(string query);
    }

}
