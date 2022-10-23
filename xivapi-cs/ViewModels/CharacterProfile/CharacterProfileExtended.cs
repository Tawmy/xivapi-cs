namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class CharacterProfileExtended : CharacterProfileBase
    {
        // AC
        public CharacterProfileExtended(DTOs.CharacterProfile.CharacterProfileExtended dto) : base(dto)
        {
            Achievements = new AchievementsExtended(dto.Achievements);
            AchievementsPublic = dto.AchievementsPublic == true;
            Character = new CharacterExtended(dto.Character);
        }

        public AchievementsExtended Achievements { get; }
        public bool AchievementsPublic { get; }

        // default
        public CharacterExtended Character { get; }
    }
}