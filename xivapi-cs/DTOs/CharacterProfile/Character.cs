namespace xivapi_cs.DTOs.CharacterProfile
{
    public class Character : CharacterBase
    {
        public ClassJob ActiveClassJob { get; init; }
        public ClassJob[] ClassJobs { get; init; }
        public GearSet GearSet { get; init; }
        public GrandCompany? GrandCompany { get; init; }
        public int GuardianDeity { get; init; }
        public int Race { get; init; }
        public int Title { get; init; }
        public int Town { get; init; }
        public int Tribe { get; init; }
    }
}