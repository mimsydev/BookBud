using System.Text.Json.Serialization;

namespace BookBud.Server.BookProvider.OpenLib
{
public record BookDetail : IProvidedBook
{
    [JsonPropertyName("type")]
    public TypeReference? Type { get; init; }
    
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    
    [JsonPropertyName("authors")]
    public List<Author>? Authors { get; init; }
    
    [JsonPropertyName("publish_date")]
    public string? PublishDate { get; init; }
    
    [JsonPropertyName("source_records")]
    public List<string>? SourceRecords { get; init; }
    
    [JsonPropertyName("publishers")]
    public List<string>? Publishers { get; init; }
    
    [JsonPropertyName("physical_format")]
    public string? PhysicalFormat { get; init; }
    
    [JsonPropertyName("works")]
    public List<Work>? Works { get; init; }
    
    [JsonPropertyName("key")]
    public string? Key { get; init; }
    
    [JsonPropertyName("covers")]
    public List<int>? Covers { get; init; }
    
    [JsonPropertyName("identifiers")]
    public Dictionary<string, object>? Identifiers { get; init; }
    
    [JsonPropertyName("isbn_10")]
    public List<string>? Isbn10 { get; init; }
    
    [JsonPropertyName("isbn_13")]
    public List<string>? Isbn13 { get; init; }
    
    [JsonPropertyName("classifications")]
    public Dictionary<string, object>? Classifications { get; init; }
    
    [JsonPropertyName("latest_revision")]
    public int? LatestRevision { get; init; }
    
    [JsonPropertyName("revision")]
    public int? Revision { get; init; }
    
    [JsonPropertyName("created")]
    public DateTimeReference? Created { get; init; }
    
    [JsonPropertyName("last_modified")]
    public DateTimeReference? LastModified { get; init; }
}

public record Author
{
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}

public record Work
{
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}

public record TypeReference
{
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}

public record DateTimeReference
{
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}
}
