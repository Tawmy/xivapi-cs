using System;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class GrandCompanyExtended
{
    internal GrandCompanyExtended(DTOs.CharacterProfile.GrandCompanyExtended dto)
    {
        Company = new UrlAttribute(dto.Company);
        Rank = new IconUrlAttribute(dto.Rank);
        GrandCompanyEnum = Company.Id switch
        {
            1 => Enums.GrandCompany.Maelstrom,
            2 => Enums.GrandCompany.OrderTwinAdder,
            3 => Enums.GrandCompany.ImmortalFlames,
            _ => throw new ArgumentOutOfRangeException(nameof(Company.Id), Company.Id,
                "there are only three grand companies")
        };
    }

    public UrlAttribute Company { get; }
    public IconUrlAttribute Rank { get; }
    public Enums.GrandCompany GrandCompanyEnum { get; }
}