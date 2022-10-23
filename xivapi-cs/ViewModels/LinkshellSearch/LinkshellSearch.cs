using System.Linq;

namespace xivapi_cs.ViewModels.LinkshellSearch
{
    public class LinkshellSearch : LinkshellSearchBase
    {
        internal LinkshellSearch(DTOs.LinkshellSearch.LinkshellSearch dto) : base(dto)
        {
            Results = dto.Results.Select(x => new LinkshellSearchResult(x)).ToArray();
        }
        
        public LinkshellSearchResult[] Results { get; }
    }
}