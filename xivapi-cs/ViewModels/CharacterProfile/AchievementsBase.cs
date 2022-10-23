namespace xivapi_cs.ViewModels.CharacterProfile;

public class AchievementsBase
{
    public AchievementsBase(DTOs.CharacterProfile.AchievementsBase dto)
    {
        Points = dto.Points;
    }

    public int Points { get; }
}