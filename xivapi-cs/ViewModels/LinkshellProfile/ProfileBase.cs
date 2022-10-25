namespace xivapi_cs.ViewModels.LinkshellProfile;

public class ProfileBase
{
    internal ProfileBase(DTOs.LinkshellProfile.Profile dto)
    {
        Name = dto.Name;
    }

    public string Name { get; }
}