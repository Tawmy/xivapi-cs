using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class ClassJob : ClassJobBase
{
    [JsonPropertyName("ClassID")] public int ClassId { get; init; }

    [JsonPropertyName("JobID")] public int JobId { get; init; }
}