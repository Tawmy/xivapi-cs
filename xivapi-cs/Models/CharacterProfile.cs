namespace xivapi_cs.Models
{
    public class CharacterProfile
    {
        public Achievements Achievements { get; set; }
        public bool? AchievementsPublic { get; set; }
        public Character Character { get; set; }
        public FreeCompany FreeCompany { get; set; }
        public FreeCompanyMember[] FreeCompanyMembers { get; set; }
        public Pet[] Minions { get; set; }
        public Pet[] Mounts { get; set; }
    }
}