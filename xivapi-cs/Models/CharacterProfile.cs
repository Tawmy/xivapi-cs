namespace xivapi_cs.Models
{
    public class CharacterProfile
    {
        public Character Character { get; set; }
        public FreeCompany FreeCompany { get; set; }
        public FreeCompanyMember[] FreeCompanyMembers { get; set; }
    }
}