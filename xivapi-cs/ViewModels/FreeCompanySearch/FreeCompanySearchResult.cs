using xivapi_cs.Models;

namespace xivapi_cs.ViewModels.FreeCompanySearch
{
    public class FreeCompanySearchResult
    {
        internal FreeCompanySearchResult(DTOs.FreeCompanySearch.FreeCompanySearchResult dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            Crest = dto.Crest;
            HomeWorldDetails = new HomeWorldDetails(dto.Server.Split(" ")[0]); // string includes logical data center
        }

        public string Id { get; }
        public string Name { get; }
        public string[] Crest { get; }
        public HomeWorldDetails HomeWorldDetails { get; }
    }
}