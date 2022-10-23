namespace xivapi_cs.DTOs.CharacterProfile
{
    public class GearPieceExtended : GearPieceBase
    {
        public IconAttribute? Dye { get; init; }
        public Item Item { get; init; }
        public IconUrlAttribute[] Materia { get; init; }
        public IconAttribute? Mirage { get; init; }
    }
}