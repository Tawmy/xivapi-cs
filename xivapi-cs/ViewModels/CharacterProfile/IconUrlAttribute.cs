namespace xivapi_cs.ViewModels.CharacterProfile;

public class IconUrlAttribute : UrlAttribute
{
    public IconUrlAttribute(DTOs.CharacterProfile.IconUrlAttribute dto) : base(dto)
    {
        Icon = dto.Icon;
    }

    public string Icon { get; }
}