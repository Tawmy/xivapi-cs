using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class CharacterExtended : CharacterBase
{
    public ClassJobExtended ActiveClassJob { get; init; } = null!;
    public ClassJobExtended[] ClassJobs { get; init; } = null!;
    public GearSetExtended GearSet { get; init; } = null!;

    [JsonPropertyName("GenderID")] public int GenderId { get; init; }

    public GrandCompanyExtended? GrandCompany { get; init; }
    public GuardianDeity GuardianDeity { get; init; } = null!;
    public UrlAttribute Race { get; init; } = null!;
    public IconUrlAttribute Title { get; init; } = null!;
    public IconUrlAttribute Town { get; init; } = null!;
    public IconUrlAttribute Tribe { get; init; } = null!;
}