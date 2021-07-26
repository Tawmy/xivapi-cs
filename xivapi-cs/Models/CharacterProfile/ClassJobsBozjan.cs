namespace xivapi_cs.Models.CharacterProfile
{
    public class ClassJobsBozjan
    {
        public int? Level { get; set; }
        public dynamic Mettle { get; set; } // null when not unlocked, int when in int range, otherwise string.empty
        public string Name { get; set; }
    }
}