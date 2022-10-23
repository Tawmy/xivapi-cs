namespace xivapi_cs.ViewModels.CharacterProfile;

public class IconAttribute : Attribute
{
    internal IconAttribute(DTOs.CharacterProfile.IconAttribute dto) : base(dto)
    {
        Icon = dto.Icon;
    }

    public string Icon { get; }
}