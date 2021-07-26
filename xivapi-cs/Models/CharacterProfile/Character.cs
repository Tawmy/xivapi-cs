namespace xivapi_cs.Models.CharacterProfile
{
    public class Character : CharacterBase
    {
        public ClassJob ActiveClassJob { get; set; }
        public ClassJob[] ClassJobs { get; set; }
        public GearSet GearSet { get; set; }
        public GrandCompany GrandCompany { get; set; }
        public int GuardianDeity { get; set; }
        public int Race { get; set; }
        public int Title { get; set; }
        public int Town { get; set; }
        public int Tribe { get; set; }
    }
}