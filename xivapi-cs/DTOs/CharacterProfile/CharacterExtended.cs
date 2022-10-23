using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile
{
    public class CharacterExtended : CharacterBase
    {
        public ClassJobExtended ActiveClassJob { get; init; }
        public ClassJobExtended[] ClassJobs { get; init; }
        public GearSetExtended GearSet { get; init; }
        
        [JsonPropertyName("GenderID")]
        public int GenderId { get; init; }
        
        public GrandCompanyExtended? GrandCompany { get; init; }
        public GuardianDeity GuardianDeity { get; init; }
        public UrlAttribute Race { get; init; }
        public IconUrlAttribute Title { get; init; }
        public IconUrlAttribute Town { get; init; }
        public IconUrlAttribute Tribe { get; init; }
    }
}