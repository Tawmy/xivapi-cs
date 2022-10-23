using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.LinkshellProfile
{
    internal class Linkshell
    {
        // why is this a thing
        [JsonPropertyName("Linkshell")] public LinkshellProfile LinkshellProfile { get; init; } = null!;
    }
}