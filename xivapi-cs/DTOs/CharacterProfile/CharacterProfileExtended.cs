namespace xivapi_cs.DTOs.CharacterProfile;

internal class CharacterProfileExtended : CharacterProfileBase
{
    // AC
    public AchievementsExtended Achievements { get; init; } = null!;
    public bool? AchievementsPublic { get; init; }

    // default
    public CharacterExtended Character { get; init; } = null!;
}