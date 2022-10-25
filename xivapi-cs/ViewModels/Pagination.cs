namespace xivapi_cs.ViewModels;

public class Pagination
{
    internal Pagination(DTOs.Pagination dto)
    {
        Page = dto.Page;
        PageNext = dto.PageNext;
        PagePrev = dto.PagePrev;
        PageTotal = dto.PageTotal;
        Results = dto.Results;
        ResultsPerPage = dto.ResultsPerPage;
        ResultsTotal = dto.ResultsTotal;
    }

    public int Page { get; }
    public int? PageNext { get; }
    public int? PagePrev { get; }
    public int PageTotal { get; }
    public int Results { get; }
    public int ResultsPerPage { get; }
    public int ResultsTotal { get; }
}