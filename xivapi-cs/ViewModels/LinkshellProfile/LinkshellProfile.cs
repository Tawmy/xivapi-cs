namespace xivapi_cs.ViewModels.LinkshellProfile;

public class LinkshellProfile : LinkshellProfileBase
{
    internal LinkshellProfile(DTOs.LinkshellProfile.LinkshellProfile dto) : base(dto)
    {
        Profile = new Profile(dto.Profile, dto.Results);
    }

    public Profile Profile { get; }
}