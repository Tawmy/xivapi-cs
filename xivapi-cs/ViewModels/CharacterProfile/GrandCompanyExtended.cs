namespace xivapi_cs.ViewModels.CharacterProfile;

public class GrandCompanyExtended
{
    internal GrandCompanyExtended(DTOs.CharacterProfile.GrandCompanyExtended dto)
    {
        Company = new UrlAttribute(dto.Company);
        Rank = new IconUrlAttribute(dto.Rank);
        GrandCompanyEnum = (Enums.GrandCompany) Company.Id;
    }

    public UrlAttribute Company { get; }
    public IconUrlAttribute Rank { get; }
    public Enums.GrandCompany GrandCompanyEnum { get; }
}