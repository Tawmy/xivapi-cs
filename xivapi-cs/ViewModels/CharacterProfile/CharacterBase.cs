namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class CharacterBase
    {
        public string Avatar { get; set; }
        public string Bio { get; set; }
        public ClassJobsBozjan ClassJobsBozjan { get; set; }
        public ClassJobsElemental ClassJobsElemental { get; set; }

        // ReSharper disable once InconsistentNaming
        public string DC { get; set; }

        public string FreeCompanyId { get; set; }
        public string FreeCompanyName { get; set; }
        public int Gender { get; set; }
        public int ID { get; set; }
        public dynamic Lang { get; set; } // no clue, seems to always be null
        public string Name { get; set; }
        public string Nameday { get; set; }
        public int ParseDate { get; set; }
        public string Portrait { get; set; }
        public int? PvPTeamId { get; set; }
        public string Server { get; set; }
        public bool TitleTop { get; set; }
    }
}