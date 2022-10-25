namespace xivapi_cs.ViewModels.CharacterProfile;

public class UrlAttribute : Attribute
{
    internal UrlAttribute(DTOs.CharacterProfile.UrlAttribute dto) : base(dto)
    {
        Url = dto.Url;
    }

    public string Url { get; }
}