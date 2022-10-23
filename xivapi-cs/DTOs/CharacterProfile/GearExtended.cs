namespace xivapi_cs.DTOs.CharacterProfile
{
    public class GearExtended
    {
        public GearPieceExtended? Body { get; init; }
        public GearPieceExtended? Bracelets { get; init; }
        public GearPieceExtended? Earrings { get; init; }
        public GearPieceExtended? Feet { get; init; }
        public GearPieceExtended? Hands { get; init; }
        public GearPieceExtended? Head { get; init; }
        public GearPieceExtended? Legs { get; init; }
        public GearPieceExtended MainHand { get; init; } = null!;
        public GearPieceExtended? Necklace { get; init; }
        public GearPieceExtended? OffHand { get; init; }
        public GearPieceExtended? Ring1 { get; init; }
        public GearPieceExtended? Ring2 { get; init; }
        public GearPieceExtended? SoulCrystal { get; init; }
    }
}