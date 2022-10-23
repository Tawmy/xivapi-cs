using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

public class GearSet
{
    public Dictionary<string, int> Attributes { get; init; }

    [JsonPropertyName("ClassID")] public int ClassId { get; init; }

    public Gear Gear { get; init; }
}