namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class CharacterProfileBase
    {
        // FR
        public CharacterShort[] Friends { get; set; }
        public bool? FriendsPublic { get; set; }

        // FC
        public FreeCompany FreeCompany { get; set; }

        // FCM
        public CharacterShort[] FreeCompanyMembers { get; set; }

        // MIMO
        public Pet[] Minions { get; set; }
        public Pet[] Mounts { get; set; }
    }
}