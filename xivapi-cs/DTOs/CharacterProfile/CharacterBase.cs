using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile;

internal class CharacterBase : Attribute
{
    public string Avatar { get; init; } = null!;
    public string Bio { get; init; } = null!;
    public ClassJobsBozjan ClassJobsBozjan { get; init; } = null!;
    public ClassJobsElemental ClassJobsElemental { get; init; } = null!;

    [JsonPropertyName("DC")] public string Dc { get; init; } = null!;

    public string? FreeCompanyId { get; init; }
    public string? FreeCompanyName { get; init; }
    public int Gender { get; init; }
    public object? Lang { get; init; } // no clue, seems to always be null
    public string Nameday { get; init; } = null!;
    public int ParseDate { get; init; }
    public string Portrait { get; init; } = null!;
    public int? PvPTeamId { get; init; }
    public string Server { get; init; } = null!;
    public bool TitleTop { get; init; }
}