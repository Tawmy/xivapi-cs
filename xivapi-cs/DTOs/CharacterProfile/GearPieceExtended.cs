namespace xivapi_cs.DTOs.CharacterProfile;

internal class GearPieceExtended : GearPieceBase
{
    public IconAttribute? Dye { get; init; }
    public Item Item { get; init; } = null!;
    public IconUrlAttribute[] Materia { get; init; } = null!;
    public IconAttribute? Mirage { get; init; }
}