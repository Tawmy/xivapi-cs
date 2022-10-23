namespace xivapi_cs.ViewModels.CharacterProfile;

public class Pet
{
    internal Pet(DTOs.CharacterProfile.Pet dto)
    {
        Icon = dto.Icon;
        Name = dto.Name;
    }

    public string Icon { get; }
    public string Name { get; }
}