using System.Linq;

namespace xivapi_cs.ViewModels.FreeCompanySearch;

public class FreeCompanySearch
{
    internal FreeCompanySearch(DTOs.FreeCompanySearch.FreeCompanySearch dto)
    {
        Pagination = new Pagination(dto.Pagination);
        Results = dto.Results.Select(x => new FreeCompanySearchResult(x)).ToArray();
    }

    public Pagination Pagination { get; set; }
    public FreeCompanySearchResult[] Results { get; set; }
}