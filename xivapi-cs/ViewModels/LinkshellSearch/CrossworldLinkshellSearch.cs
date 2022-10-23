using System.Linq;

namespace xivapi_cs.ViewModels.LinkshellSearch;

public class CrossworldLinkshellSearch : LinkshellSearchBase
{
    internal CrossworldLinkshellSearch(DTOs.LinkshellSearch.LinkshellSearch dto) : base(dto)
    {
        Results = dto.Results.Select(x => new CrossworldLinkshellSearchResult(x)).ToArray();
    }

    public CrossworldLinkshellSearchResult[] Results { get; }
}