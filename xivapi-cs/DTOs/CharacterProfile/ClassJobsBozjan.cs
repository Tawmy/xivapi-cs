namespace xivapi_cs.DTOs.CharacterProfile
{
    public class ClassJobsBozjan
    {
        public int? Level { get; init; }
        public object Mettle { get; init; }    // null when not unlocked, int when in int range, otherwise string.empty
        public string Name { get; init; }
    }
}