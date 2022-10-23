using System.Linq;

namespace xivapi_cs.ViewModels.CharacterSearch
{
    public class CharacterSearch
    {
        internal CharacterSearch(DTOs.CharacterSearch.CharacterSearch dto)
        {
            Pagination = new Pagination(dto.Pagination);
            Results = dto.Results.Select(x => new CharacterSearchResult(x)).ToArray();
        }

        public Pagination Pagination { get; }
        public CharacterSearchResult[] Results { get; }
    }
}