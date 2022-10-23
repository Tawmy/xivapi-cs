using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile
{
    public class CharacterBase : Attribute
    {
        public string Avatar { get; init; }
        public string Bio { get; init; }
        public ClassJobsBozjan ClassJobsBozjan { get; init; }
        public ClassJobsElemental ClassJobsElemental { get; init; }

        [JsonPropertyName("DC")]
        public string Dc { get; init; }

        public string FreeCompanyId { get; init; }
        public string FreeCompanyName { get; init; }
        public int Gender { get; init; }
        public dynamic Lang { get; init; } // no clue, seems to always be null
        public string Nameday { get; init; }
        public int ParseDate { get; init; }
        public string Portrait { get; init; }
        public int? PvPTeamId { get; init; }
        public string Server { get; init; }
        public bool TitleTop { get; init; }
    }
}