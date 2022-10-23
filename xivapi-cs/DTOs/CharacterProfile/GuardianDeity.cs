using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

public class GuardianDeity : IconUrlAttribute
{
    [JsonPropertyName("GuardianDeity")] public dynamic GuardianDeityChild { get; init; } // TODO data type
}