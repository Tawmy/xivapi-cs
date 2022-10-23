namespace xivapi_cs.ViewModels.LinkshellProfile;

public class CrossworldLinkshellProfile : LinkshellProfileBase
{
    internal CrossworldLinkshellProfile(DTOs.LinkshellProfile.LinkshellProfile dto) : base(dto)
    {
        Profile = new CrossworldProfile(dto.Profile);
    }

    public CrossworldProfile Profile { get; }
}
