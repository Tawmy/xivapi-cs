namespace xivapi_cs.ViewModels.CharacterProfile;

public class GrandCompany
{
    internal GrandCompany(DTOs.CharacterProfile.GrandCompany dto)
    {
        NameId = dto.NameId;
        RankId = dto.RankId;
        GrandCompanyEnum = (Enums.GrandCompany) NameId;
    }

    public int NameId { get; }
    public int RankId { get; }
    public Enums.GrandCompany GrandCompanyEnum { get; }
}