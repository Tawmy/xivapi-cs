namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class CharacterProfile : CharacterProfileBase
    {
        // AC
        public CharacterProfile(DTOs.CharacterProfile.CharacterProfile dto) : base(dto)
        {
            if (dto.Achievements != null)
            {
                Achievements = new Achievements(dto.Achievements);
            }
            
            AchievementsPublic = dto.AchievementsPublic == true;
            Character = new Character(dto.Character);
        }

        public Achievements? Achievements { get; }
        public bool AchievementsPublic { get; }

        // default
        public Character Character { get; }
    }
}