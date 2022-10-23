namespace xivapi_cs.DTOs.FreeCompanySearch;

internal class FreeCompanySearch
{
    public Pagination Pagination { get; init; } = null!;
    public FreeCompanySearchResult[] Results { get; init; } = null!;
}