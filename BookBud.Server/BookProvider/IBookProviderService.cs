namespace BookBud.Server.BookProvider
{
    public interface IBookProviderService
    {
        public Task<IEnumerable<ISearchResult>> SearchBooksAsync(string query);
        public Task<IProvidedBook> GetBookAsync(string query);
    }

}
