namespace xivapi_cs.Models
{
    public class CharacterProfile
    {
        // AC
        public Achievements Achievements { get; set; }
        public bool? AchievementsPublic { get; set; }

        // FR
        public CharacterShort[] Friends { get; set; }
        public bool? FriendsPublic { get; set; }

        // default
        public Character Character { get; set; }

        // FC
        public FreeCompany FreeCompany { get; set; }

        // FCM
        public CharacterShort[] FreeCompanyMembers { get; set; }

        // MIMO
        public Pet[] Minions { get; set; }
        public Pet[] Mounts { get; set; }
    }
}