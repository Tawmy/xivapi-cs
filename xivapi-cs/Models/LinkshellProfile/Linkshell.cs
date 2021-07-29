using System.Text.Json.Serialization;

namespace xivapi_cs.Models.LinkshellProfile
{
    public class Linkshell
    {
        // why is this a thing
        [JsonPropertyName("Linkshell")] public LinkshellProfile LinkshellProfile { get; set; }
    }
}