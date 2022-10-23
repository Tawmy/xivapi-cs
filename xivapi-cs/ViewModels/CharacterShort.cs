namespace xivapi_cs.ViewModels
{
    public class CharacterShort
    {
        internal CharacterShort(DTOs.CharacterShort dto)
        {
            Avatar = dto.Avatar;
            FeastMatches = dto.FeastMatches;
            Id = dto.ID;
            Lang = dto.Lang;
            Name = dto.Name;
            Rank = dto.Rank;
            RankIcon = dto.RankIcon;
            Server = dto.Server;
        }

        public string Avatar { get; set; }
        public int FeastMatches { get; set; }
        public int Id { get; set; }
        public dynamic Lang { get; set; } // no clue, seems to always be null
        public string Name { get; set; }
        public string Rank { get; set; }
        public string RankIcon { get; set; }
        public string Server { get; set; }
    }
}