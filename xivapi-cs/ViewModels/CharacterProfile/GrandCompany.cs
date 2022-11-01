using System;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class GrandCompany
{
    internal GrandCompany(DTOs.CharacterProfile.GrandCompany dto)
    {
        NameId = dto.NameId;
        RankId = dto.RankId;
        GrandCompanyEnum = NameId switch
        {
            1 => Enums.GrandCompany.Maelstrom,
            2 => Enums.GrandCompany.OrderTwinAdder,
            3 => Enums.GrandCompany.ImmortalFlames,
            _ => throw new ArgumentOutOfRangeException(nameof(NameId), NameId, "there are only three grand companies")
        };
    }

    public int NameId { get; }
    public int RankId { get; }
    public Enums.GrandCompany GrandCompanyEnum { get; }
}