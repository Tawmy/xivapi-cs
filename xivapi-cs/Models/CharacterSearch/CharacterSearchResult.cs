namespace xivapi_cs.Models.CharacterSearch
{
    public class CharacterSearchResult
    {
        public string Avatar { get; set; }
        public int FeastMatches { get; set; }
        public int ID { get; set; }
        public string Lang { get; set; }
        public string Name { get; set; }
        public dynamic Rank { get; set; } // no clue, seems to always be null
        public dynamic RankIcon { get; set; } // no clue, seems to always be null
        public string Server { get; set; }
    }
}