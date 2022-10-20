using System.Text.Json.Serialization;

namespace xivapi_cs.ViewModels.LinkshellProfile
{
    public class Linkshell
    {
        // why is this a thing
        [JsonPropertyName("Linkshell")] public LinkshellProfile LinkshellProfile { get; set; }
    }
}