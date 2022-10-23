using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs;

internal class CharacterShort
{
    public string Avatar { get; init; } = null!;
    public int FeastMatches { get; init; }

    [JsonPropertyName("ID")] public int Id { get; init; }

    public object? Lang { get; init; } // no clue, seems to always be null
    public string Name { get; init; } = null!;
    public string Rank { get; init; } = null!;
    public string RankIcon { get; init; } = null!;
    public string Server { get; init; } = null!;
}