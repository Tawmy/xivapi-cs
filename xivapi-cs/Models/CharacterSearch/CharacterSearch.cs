namespace xivapi_cs.Models.CharacterSearch
{
    public class CharacterSearch
    {
        public CharacterSearchPagination Pagination { get; set; }
        public CharacterSearchResult[] Results { get; set; }
    }
}