namespace xivapi_cs.DTOs.CharacterProfile;

internal class GearSetExtended
{
    public GearSetAttribute[] Attributes { get; init; } = null!;
    public Job Class { get; init; } = null!; // Job type because no ClassJobCategory from API
    public GearExtended Gear { get; init; } = null!;
}