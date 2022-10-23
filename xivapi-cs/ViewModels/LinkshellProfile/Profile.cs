using xivapi_cs.Models;

namespace xivapi_cs.ViewModels.LinkshellProfile
{
    public class Profile
    {
        internal Profile(DTOs.LinkshellProfile.Profile dto)
        {
            Name = dto.Name;
            HomeWorldDetails = new HomeWorldDetails(dto.Server);
        }

        public string Name { get; }
        public HomeWorldDetails HomeWorldDetails { get; }
    }
}