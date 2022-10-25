using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class GearSet
{
    public Dictionary<string, int> Attributes { get; init; } = null!;

    [JsonPropertyName("ClassID")] public int ClassId { get; init; }

    public Gear Gear { get; init; } = null!;
}