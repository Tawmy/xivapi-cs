namespace xivapi_cs.DTOs.CharacterProfile
{
    public class CharacterProfile : CharacterProfileBase
    {
        // AC
        public Achievements? Achievements { get; init; }
        public bool? AchievementsPublic { get; init; }

        // default
        public Character Character { get; init; }
    }
}