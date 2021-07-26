using xivapi_cs.Models.CharacterProfile;

namespace xivapi_cs.Models.FreeCompanyProfile
{
    public class FreeCompanyProfile
    {
        public FreeCompany FreeCompany { get; set; }
        public CharacterShort[] FreeCompanyMembers { get; set; }
    }
}