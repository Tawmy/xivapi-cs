namespace xivapi_cs.DTOs.CharacterProfile;

internal class AchievementExtended : Achievement
{
    public string Icon { get; init; } = null!;
    public string Name { get; init; } = null!;
    public int Points { get; init; }
}