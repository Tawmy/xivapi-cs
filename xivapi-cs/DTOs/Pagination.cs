namespace xivapi_cs.DTOs;

internal class Pagination
{
    public int Page { get; init; }
    public int? PageNext { get; init; }
    public int? PagePrev { get; init; }
    public int PageTotal { get; init; }
    public int Results { get; init; }
    public int ResultsPerPage { get; init; }
    public int ResultsTotal { get; init; }
}