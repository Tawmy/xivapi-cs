namespace xivapi_cs.DTOs.CharacterProfile
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