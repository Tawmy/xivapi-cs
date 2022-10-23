using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

public class GearPiece : GearPieceBase
{
    public int? Dye { get; init; }
    public int? Mirage { get; init; }

    [JsonPropertyName("ID")] public int Id { get; init; }

    public int[] Materia { get; init; }
}