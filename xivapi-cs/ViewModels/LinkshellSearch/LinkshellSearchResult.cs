using xivapi_cs.Models;

namespace xivapi_cs.ViewModels.LinkshellSearch;

public class LinkshellSearchResult : LinkshellSearchResultBase
{
    internal LinkshellSearchResult(DTOs.LinkshellSearch.LinkshellSearchResult dto) : base(dto)
    {
        HomeWorldDetails = new HomeWorldDetails(dto.Server);
    }

    public HomeWorldDetails HomeWorldDetails { get; }
}