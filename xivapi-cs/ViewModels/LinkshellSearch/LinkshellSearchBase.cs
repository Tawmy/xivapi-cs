namespace xivapi_cs.ViewModels.LinkshellSearch;

public class LinkshellSearchBase
{
    internal LinkshellSearchBase(DTOs.LinkshellSearch.LinkshellSearch dto)
    {
        Pagination = new Pagination(dto.Pagination);
    }

    public Pagination Pagination { get; }
}