using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class GuardianDeity : IconUrlAttribute
{
    [JsonPropertyName("GuardianDeity")] public object GuardianDeityChild { get; init; } = null!; // TODO data type
}