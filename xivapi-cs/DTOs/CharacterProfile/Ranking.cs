namespace xivapi_cs.DTOs.CharacterProfile;

internal class Ranking
{
    public object Monthly { get; init; } = null!; // string "--" when empty instead of usual integer type
    public object Weekly { get; init; } = null!; // string "--" when empty instead of usual integer type
}