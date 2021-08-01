namespace xivapi_cs.Models.CharacterProfile
{
    public class GearPiece : GearPieceBase
    {
        public int? Dye { get; set; }
        public int? Mirage { get; set; }
        public int ID { get; set; }
        public int[] Materia { get; set; }
    }
}