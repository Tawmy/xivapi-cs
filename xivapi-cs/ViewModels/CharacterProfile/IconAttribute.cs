namespace xivapi_cs.ViewModels.CharacterProfile;

public class IconAttribute : Attribute
{
    public IconAttribute(DTOs.CharacterProfile.IconAttribute dto) : base(dto)
    {
        Icon = dto.Icon;
    }

    public string Icon { get; }
}