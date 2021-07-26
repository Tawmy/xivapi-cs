using xivapi_cs.Models.CharacterProfile;

namespace xivapi_cs.Models
{
    public class FreeCompany
    {
        public string Active { get; set; }
        public int ActiveMemberCount { get; set; }
        public string[] Crest { get; set; }

        // ReSharper disable once InconsistentNaming
        public string DC { get; set; }

        public Estate Estate { get; set; }
        public Focus[] Focus { get; set; }
        public int Formed { get; set; }
        public string GrandCompany { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public int ParseDate { get; set; }
        public int Rank { get; set; }
        public Ranking Ranking { get; set; }
        public string Recruitment { get; set; }
        public Reputation[] Reputation { get; set; }
        public Seeking[] Seeking { get; set; }
        public string Server { get; set; }
        public string Slogan { get; set; }
        public string Tag { get; set; }
    }
}