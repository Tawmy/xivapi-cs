namespace xivapi_cs.DTOs.CharacterProfile;

internal class ClassJobExtended : ClassJobBase
{
    public Class Class { get; init; } = null!;
    public Job Job { get; init; } = null!;
}