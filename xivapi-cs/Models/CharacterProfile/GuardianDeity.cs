using System.Text.Json.Serialization;

namespace xivapi_cs.Models.CharacterProfile
{
    public class GuardianDeity
    {
        [JsonPropertyName("GuardianDeity")] public dynamic GuardianDeityChild { get; set; } // TODO data type
        public int ID { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}