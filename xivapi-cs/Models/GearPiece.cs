namespace xivapi_cs.Models
{
    public class GearPiece
    {
        public dynamic Creator { get; set; } // no clue, seems to always be null
        public int? Dye { get; set; }
        public int ID { get; set; }
        public int[] Materia { get; set; }
        public int? Mirage { get; set; }
    }
}