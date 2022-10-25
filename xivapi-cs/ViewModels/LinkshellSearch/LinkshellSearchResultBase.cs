namespace xivapi_cs.ViewModels.LinkshellSearch;

public class LinkshellSearchResultBase
{
    internal LinkshellSearchResultBase(DTOs.LinkshellSearch.LinkshellSearchResult dto)
    {
        Id = dto.Id;
        Name = dto.Name;
        Crest = dto.Crest;
    }

    public string Id { get; }
    public string Name { get; }
    public string[] Crest { get; }
}