using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class UnlockedState
{
    [JsonPropertyName("ID")] public int? Id { get; init; }

    public string Name { get; init; } = null!;
}