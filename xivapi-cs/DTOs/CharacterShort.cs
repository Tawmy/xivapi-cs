namespace xivapi_cs.DTOs
{
    public class CharacterShort
    {
        public string Avatar { get; init; }
        public int FeastMatches { get; init; }
        public int ID { get; init; }
        public dynamic Lang { get; init; } // no clue, seems to always be null
        public string Name { get; init; }
        public string Rank { get; init; }
        public string RankIcon { get; init; }
        public string Server { get; init; }
    }
}