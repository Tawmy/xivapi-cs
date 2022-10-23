namespace xivapi_cs.DTOs.CharacterProfile
{
    public class Ranking
    {
        public object Monthly { get; init; }   // string "--" when empty instead of usual integer type
        public object Weekly { get; init; }    // string "--" when empty instead of usual integer type
    }
}