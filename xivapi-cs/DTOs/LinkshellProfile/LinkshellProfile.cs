using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.LinkshellProfile
{
    internal class LinkshellProfile
    {
        [JsonPropertyName("ID")]
        public string Id { get; set; }
        
        public Pagination Pagination { get; set; }
        public Profile Profile { get; set; }
        public CharacterShort[] Results { get; set; }
    }
}