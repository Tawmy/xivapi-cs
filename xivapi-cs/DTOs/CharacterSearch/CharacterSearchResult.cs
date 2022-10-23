using xivapi_cs.DTOs.CharacterProfile;

namespace xivapi_cs.DTOs.CharacterSearch;

internal class CharacterSearchResult : Attribute
{
    public string Avatar { get; init; } = null!;
    public int FeastMatches { get; init; }
    public string Lang { get; init; } = null!;
    public object? Rank { get; init; } // no clue, seems to always be null
    public object? RankIcon { get; init; } // no clue, seems to always be null
    public string Server { get; init; } = null!;
}