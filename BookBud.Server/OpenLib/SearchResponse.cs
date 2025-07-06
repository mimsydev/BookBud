using System.Text.Json.Serialization;

namespace BookBud.Server.BookProvider.OpenLib
{
public record SearchResponse
{
    [JsonPropertyName("numFound")]
    public int? NumFound { get; init; }
    
    [JsonPropertyName("start")]
    public int? Start { get; init; }
    
    [JsonPropertyName("numFoundExact")]
    public bool? NumFoundExact { get; init; }
    
    [JsonPropertyName("num_found")]
    public int? NumFoundAlternate { get; init; }
    
    [JsonPropertyName("documentation_url")]
    public string? DocumentationUrl { get; init; }
    
    [JsonPropertyName("q")]
    public string? Query { get; init; }
    
    [JsonPropertyName("offset")]
    public object? Offset { get; init; }
    
    [JsonPropertyName("docs")]
    public List<Book>? Books { get; init; }
}

public record Book : ISearchResult
{
    [JsonPropertyName("author_key")]
    public List<string>? AuthorKey { get; init; }
    
    [JsonPropertyName("author_name")]
    public List<string>? AuthorName { get; init; }
    
    [JsonPropertyName("cover_edition_key")]
    public string? CoverEditionKey { get; init; }
    
    [JsonPropertyName("cover_i")]
    public int? CoverImageId { get; init; }
    
    [JsonPropertyName("ebook_access")]
    public string? EbookAccess { get; init; }
    
    [JsonPropertyName("edition_count")]
    public int? EditionCount { get; init; }
    
    [JsonPropertyName("first_publish_year")]
    public int? FirstPublishYear { get; init; }
    
    [JsonPropertyName("has_fulltext")]
    public bool? HasFulltext { get; init; }
    
    [JsonPropertyName("ia")]
    public List<string>? InternetArchiveIds { get; init; }
    
    [JsonPropertyName("ia_collection_s")]
    public string? InternetArchiveCollections { get; init; }
    
    [JsonPropertyName("key")]
    public string? Key { get; init; }
    
    [JsonPropertyName("language")]
    public List<string>? Languages { get; init; }
    
    [JsonPropertyName("lending_edition_s")]
    public string? LendingEdition { get; init; }
    
    [JsonPropertyName("lending_identifier_s")]
    public string? LendingIdentifier { get; init; }
    
    [JsonPropertyName("public_scan_b")]
    public bool? PublicScan { get; init; }
    
    [JsonPropertyName("title")]
    public string? Title { get; init; }
}

}
