namespace xivapi_cs.ViewModels.CharacterProfile;

public class GrandCompanyExtended
{
    public GrandCompanyExtended(DTOs.CharacterProfile.GrandCompanyExtended dto)
    {
        Company = new UrlAttribute(dto.Company);
        Rank = new IconUrlAttribute(dto.Rank);
    }

    public UrlAttribute Company { get; }
    public IconUrlAttribute Rank { get; }
}