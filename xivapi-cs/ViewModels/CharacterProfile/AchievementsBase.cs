namespace xivapi_cs.ViewModels.CharacterProfile;

public class AchievementsBase
{
    internal AchievementsBase(DTOs.CharacterProfile.AchievementsBase dto)
    {
        Points = dto.Points;
    }

    public int Points { get; }
}