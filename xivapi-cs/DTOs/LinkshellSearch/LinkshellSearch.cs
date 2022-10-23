namespace xivapi_cs.DTOs.LinkshellSearch
{
    internal class LinkshellSearch
    {
        public Pagination Pagination { get; init; } = null!;
        public LinkshellSearchResult[] Results { get; init; } = null!;
    }
}