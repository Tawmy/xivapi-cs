using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

public class Attribute
{
    [JsonPropertyName("ID")] public int Id { get; init; }

    public string Name { get; init; }
}