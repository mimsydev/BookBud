namespace BookBud.Server.BookProvider
{
    public interface IBookProviderService<TSearchResult, TBook>
        where TSearchResult : ISearchResult
        where TBook : IProvidedBook
    {
        public Task<IEnumerable<TSearchResult>> SearchBooksAsync(string query);
        public Task<TBook> GetBookAsync(string query);
    }

}
