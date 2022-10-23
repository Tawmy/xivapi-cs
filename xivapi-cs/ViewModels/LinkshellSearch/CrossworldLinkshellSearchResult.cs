using xivapi_cs.Models;

namespace xivapi_cs.ViewModels.LinkshellSearch;

public class CrossworldLinkshellSearchResult : LinkshellSearchResultBase
{
    internal CrossworldLinkshellSearchResult(DTOs.LinkshellSearch.LinkshellSearchResult dto) : base(dto)
    {
        DataCenterDetails = new DataCenterDetails(dto.Server);
    }
    
    public DataCenterDetails DataCenterDetails { get; }
}