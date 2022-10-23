namespace xivapi_cs.DTOs.CharacterProfile;

internal class CharacterProfile : CharacterProfileBase
{
    // AC
    public Achievements? Achievements { get; init; }
    public bool? AchievementsPublic { get; init; }

    // default
    public Character Character { get; init; } = null!;
}