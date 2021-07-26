namespace xivapi_cs.Models
{
    public class GearPieceExtended : GearPieceBase
    {
        public Item Item { get; set; }
        public Materia[] Materia { get; set; }
    }
}