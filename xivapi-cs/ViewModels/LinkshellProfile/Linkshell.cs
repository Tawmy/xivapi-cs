using System.Text.Json.Serialization;

namespace xivapi_cs.ViewModels.LinkshellProfile;

public class Linkshell
{
    // why is this a thing
    internal Linkshell(DTOs.LinkshellProfile.Linkshell dto)
    {
        LinkshellProfile = new LinkshellProfile(dto.LinkshellProfile);
    }

    [JsonPropertyName("Linkshell")] public LinkshellProfile LinkshellProfile { get; }
}