namespace xivapi_cs.Models.CharacterProfile
{
    public class GearPieceExtended : GearPieceBase
    {
        public Dye Dye { get; set; }
        public Item Item { get; set; }
        public Materia[] Materia { get; set; }
        public Mirage Mirage { get; set; }
    }
}