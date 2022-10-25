namespace xivapi_cs.DTOs.FreeCompanyProfile;

internal class FreeCompanyProfile
{
    public FreeCompany FreeCompany { get; init; } = null!;
    public CharacterShort[]? FreeCompanyMembers { get; init; }
}