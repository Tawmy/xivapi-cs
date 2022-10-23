using System.Linq;

namespace xivapi_cs.ViewModels.LinkshellProfile
{
    public class LinkshellProfile
    {
        internal LinkshellProfile(DTOs.LinkshellProfile.LinkshellProfile dto)
        {
            Id = dto.Id;
            Pagination = new Pagination(dto.Pagination);
            Profile = new Profile(dto.Profile);
            Results = dto.Results.Select(x => new CharacterShort(x)).ToArray();
        }

        public string Id { get; }
        public Pagination Pagination { get; }
        public Profile Profile { get; }
        public CharacterShort[] Results { get; }
    }
}