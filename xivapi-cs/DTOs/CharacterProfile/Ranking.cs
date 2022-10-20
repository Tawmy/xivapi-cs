namespace xivapi_cs.DTOs.CharacterProfile
{
    public class Ranking
    {
        public dynamic Monthly { get; set; }    // string "--" when empty instead of usual integer type
        public dynamic Weekly { get; set; }     // string "--" when empty instead of usual integer type
    }
}