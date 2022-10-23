using xivapi_cs.Models;
using xivapi_cs.ViewModels.CharacterProfile;

namespace xivapi_cs.ViewModels.CharacterSearch;

public class CharacterSearchResult : Attribute
{
    internal CharacterSearchResult(DTOs.CharacterSearch.CharacterSearchResult dto) : base(dto)
    {
        Avatar = dto.Avatar;
        FeastMatches = dto.FeastMatches;
        Id = dto.Id;
        Rank = dto.Rank;
        RankIcon = dto.RankIcon;
        HomeWorldDetails = new HomeWorldDetails(dto.Server);
    }

    public string Avatar { get; }
    public int FeastMatches { get; }
    public int Id { get; }
    public object? Rank { get; } // no clue, seems to always be null
    public object? RankIcon { get; } // no clue, seems to always be null
    public HomeWorldDetails HomeWorldDetails { get; }
}