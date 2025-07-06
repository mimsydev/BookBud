using System.Text.Json.Serialization;

namespace BookBud.Server.OpenLib
{
public record EditionsResponse
{
    [JsonPropertyName("links")]
    public Links? Links { get; init; }
    
    [JsonPropertyName("size")]
    public int Size { get; init; }
    
    [JsonPropertyName("entries")]
    public List<Edition>? Entries { get; init; }
}

public record Links
{
    [JsonPropertyName("self")]
    public string? Self { get; init; }
    
    [JsonPropertyName("work")]
    public string? Work { get; init; }
    
    [JsonPropertyName("next")]
    public string? Next { get; init; }
}

public record Edition
{
    [JsonPropertyName("works")]
    public List<Work>? Works { get; init; }
    
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    
    [JsonPropertyName("publishers")]
    public List<string>? Publishers { get; init; }
    
    [JsonPropertyName("publish_date")]
    public string? PublishDate { get; init; }
    
    [JsonPropertyName("key")]
    public string? Key { get; init; }
    
    [JsonPropertyName("type")]
    public TypeReference? Type { get; init; }
    
    [JsonPropertyName("identifiers")]
    public Dictionary<string, object>? Identifiers { get; init; }
    
    [JsonPropertyName("covers")]
    public List<int>? Covers { get; init; }
    
    [JsonPropertyName("edition_name")]
    public string? EditionName { get; init; }
    
    [JsonPropertyName("contributors")]
    public List<Contributor>? Contributors { get; init; }
    
    [JsonPropertyName("languages")]
    public List<Language>? Languages { get; init; }
    
    [JsonPropertyName("translation_of")]
    public string? TranslationOf { get; init; }
    
    [JsonPropertyName("translated_from")]
    public List<Language>? TranslatedFrom { get; init; }
    
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    
    [JsonPropertyName("physical_format")]
    public string? PhysicalFormat { get; init; }
    
    [JsonPropertyName("number_of_pages")]
    public int? NumberOfPages { get; init; }
    
    [JsonPropertyName("isbn_13")]
    public List<string>? Isbn13 { get; init; }
    
    [JsonPropertyName("latest_revision")]
    public int? LatestRevision { get; init; }
    
    [JsonPropertyName("revision")]
    public int? Revision { get; init; }
    
    [JsonPropertyName("created")]
    public DateTimeReference? Created { get; init; }
    
    [JsonPropertyName("last_modified")]
    public DateTimeReference? LastModified { get; init; }
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

public record Contributor
{
    [JsonPropertyName("role")]
    public string? Role { get; init; }
    
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}

public record Language
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
