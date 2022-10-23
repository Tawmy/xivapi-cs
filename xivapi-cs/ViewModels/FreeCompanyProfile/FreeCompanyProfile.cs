using System;
using System.Linq;

namespace xivapi_cs.ViewModels.FreeCompanyProfile;

public class FreeCompanyProfile
{
    internal FreeCompanyProfile(DTOs.FreeCompanyProfile.FreeCompanyProfile dto)
    {
        FreeCompany = new FreeCompany(dto.FreeCompany);

        if (dto.FreeCompanyMembers != null)
        {
            FreeCompanyMembers = dto.FreeCompanyMembers.Select(x => new CharacterShort(x)).ToArray();
        }
    }

    public FreeCompany FreeCompany { get; }
    public CharacterShort[] FreeCompanyMembers { get; } = Array.Empty<CharacterShort>();
}