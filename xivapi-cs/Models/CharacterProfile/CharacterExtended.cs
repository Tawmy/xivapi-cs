namespace xivapi_cs.Models.CharacterProfile
{
    public class CharacterExtended : CharacterBase
    {
        public ClassJobExtended ActiveClassJob { get; set; }
        public ClassJobExtended[] ClassJobs { get; set; }
        public GearSetExtended GearSet { get; set; }
        public int GenderID { get; set; } // why
        public GrandCompanyExtended GrandCompany { get; set; }
        public GuardianDeity GuardianDeity { get; set; }
        public Race Race { get; set; }
        public Title Title { get; set; }
        public Town Town { get; set; }
        public Tribe Tribe { get; set; }
    }
}