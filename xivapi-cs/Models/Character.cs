namespace xivapi_cs.Models
{
    public class Character
    {
        public ClassJob ActiveClassJob { get; set; }
        public string Avatar { get; set; }
        public string Bio { get; set; }
        public ClassJob[] ClassJobs { get; set; }
        public ClassJobsBozjan ClassJobsBozjan { get; set; }
        public ClassJobsElemental ClassJobsElemental { get; set; }

        // ReSharper disable once InconsistentNaming
        public string DC { get; set; }

        public string FreeCompanyId { get; set; }
        public string FreeCompanyName { get; set; }
        public GearSet GearSet { get; set; }
        public int Gender { get; set; }
        public GrandCompany GrandCompany { get; set; }
        public int GuardianDeity { get; set; }
        public int ID { get; set; }
        public dynamic Lang { get; set; } // no clue, seems to always be null
        public string Name { get; set; }
        public string Nameday { get; set; }
        public int ParseDate { get; set; }
        public string Portrait { get; set; }
        public int? PvPTeamId { get; set; }
        public int Race { get; set; }
        public string Server { get; set; }
        public int Title { get; set; }
        public bool TitleTop { get; set; }
        public int Town { get; set; }
        public int Tribe { get; set; }
    }
}