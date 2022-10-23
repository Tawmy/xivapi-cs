namespace xivapi_cs.DTOs.CharacterProfile;

public class Gear
{
    public GearPiece? Body { get; init; }
    public GearPiece? Bracelets { get; init; }
    public GearPiece? Earrings { get; init; }
    public GearPiece? Feet { get; init; }
    public GearPiece? Hands { get; init; }
    public GearPiece? Head { get; init; }
    public GearPiece? Legs { get; init; }
    public GearPiece MainHand { get; init; } = null!;
    public GearPiece? Necklace { get; init; }
    public GearPiece? OffHand { get; init; }
    public GearPiece? Ring1 { get; init; }
    public GearPiece? Ring2 { get; init; }
    public GearPiece? SoulCrystal { get; init; }
}