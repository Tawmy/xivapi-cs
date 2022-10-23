using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class Achievement
{
    public int Date { get; init; }

    [JsonPropertyName("ID")] public int Id { get; init; }
}