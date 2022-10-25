using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.LinkshellSearch;

internal class LinkshellSearchResult
{
    [JsonPropertyName("ID")] public string Id { get; init; } = null!;

    public string Name { get; init; } = null!;
    public string[] Crest { get; init; } = null!;
    public string Server { get; init; } = null!;
}