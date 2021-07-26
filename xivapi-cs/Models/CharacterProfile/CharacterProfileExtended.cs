namespace xivapi_cs.Models.CharacterProfile
{
    public class CharacterProfileExtended : CharacterProfileBase
    {
        // AC
        public AchievementsExtended Achievements { get; set; }
        public bool? AchievementsPublic { get; set; }

        // default
        public CharacterExtended Character { get; set; }
    }
}