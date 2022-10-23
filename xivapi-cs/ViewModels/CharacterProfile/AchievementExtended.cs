namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class AchievementExtended : Achievement
    {
        public AchievementExtended(DTOs.CharacterProfile.AchievementExtended dto) : base(dto)
        {
            Icon = dto.Icon;
            Name = dto.Name;
            Points = dto.Points;
        }

        public string Icon { get; }
        public string Name { get; }
        public int Points { get; }
    }
}