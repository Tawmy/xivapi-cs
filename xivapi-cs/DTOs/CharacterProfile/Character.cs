namespace xivapi_cs.DTOs.CharacterProfile;

internal class Character : CharacterBase
{
    public ClassJob ActiveClassJob { get; init; } = null!;
    public ClassJob[] ClassJobs { get; init; } = null!;
    public GearSet GearSet { get; init; } = null!;
    public GrandCompany? GrandCompany { get; init; }
    public int GuardianDeity { get; init; }
    public int Race { get; init; }
    public int Title { get; init; }
    public int Town { get; init; }
    public int Tribe { get; init; }
}