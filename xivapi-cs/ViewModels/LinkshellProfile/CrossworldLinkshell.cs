using System.Text.Json.Serialization;

namespace xivapi_cs.ViewModels.LinkshellProfile;

public class CrossworldLinkshell
{
    internal CrossworldLinkshell(DTOs.LinkshellProfile.Linkshell dto)
    {
        CrossworldLinkshellProfile = new CrossworldLinkshellProfile(dto.LinkshellProfile);
    }
    
    [JsonPropertyName("Linkshell")]
    public CrossworldLinkshellProfile CrossworldLinkshellProfile { get; }
}