namespace xivapi_cs.Models
{
    public class FreeCompanyMember
    {
        public string Avatar { get; set; }
        public int FeastMatches { get; set; }
        public dynamic Lang { get; set; } // no clue, seems to always be null
        public string Name { get; set; }
        public string Rank { get; set; }
        public string RankIcon { get; set; }
        public string Server { get; set; }
    }
}