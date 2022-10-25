using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class GrandCompany
{
    [JsonPropertyName("NameID")] public int NameId { get; init; }

    [JsonPropertyName("RankID")] public int RankId { get; init; }
}