using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.LinkshellProfile;

internal class LinkshellProfile
{
    [JsonPropertyName("ID")] public string Id { get; init; } = null!;

    public Pagination Pagination { get; init; } = null!;
    public Profile Profile { get; init; } = null!;
    public CharacterShort[] Results { get; init; } = null!;
}