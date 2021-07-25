namespace xivapi_cs.Models
{
    public class CharacterSearch
    {
        public CharacterSearchPagination Pagination { get; set; }
        public CharacterSearchResult[] Results { get; set; }
    }
}