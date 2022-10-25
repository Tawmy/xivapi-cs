namespace xivapi_cs.ViewModels.CharacterProfile;

public class GrandCompany
{
    internal GrandCompany(DTOs.CharacterProfile.GrandCompany dto)
    {
        NameId = dto.NameId;
        RankId = dto.RankId;
    }

    public int NameId { get; }
    public int RankId { get; }
}