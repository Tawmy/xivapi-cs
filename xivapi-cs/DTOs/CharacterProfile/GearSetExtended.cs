namespace xivapi_cs.DTOs.CharacterProfile
{
    public class GearSetExtended
    {
        public GearSetAttribute[] Attributes { get; init; }
        public Job Class { get; init; } // Job type because no ClassJobCategory from API
        public GearExtended Gear { get; init; }
    }
}