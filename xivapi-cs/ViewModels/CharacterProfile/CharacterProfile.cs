namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class CharacterProfile : CharacterProfileBase
    {
        // AC
        public Achievements Achievements { get; set; }
        public bool? AchievementsPublic { get; set; }

        // default
        public Character Character { get; set; }
    }
}