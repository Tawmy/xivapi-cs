namespace xivapi_cs.DTOs.CharacterSearch;

internal class CharacterSearch
{
    public Pagination Pagination { get; init; } = null!;
    public CharacterSearchResult[] Results { get; init; } = null!;
}