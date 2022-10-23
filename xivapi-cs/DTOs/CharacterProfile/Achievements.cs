namespace xivapi_cs.DTOs.CharacterProfile;

internal class Achievements : AchievementsBase
{
    public Achievement[] List { get; init; } = null!;
}