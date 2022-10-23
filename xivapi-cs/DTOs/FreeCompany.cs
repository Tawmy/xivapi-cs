using System.Text.Json.Serialization;
using xivapi_cs.DTOs.CharacterProfile;

namespace xivapi_cs.DTOs;

internal class FreeCompany
{
    public string Active { get; set; } = null!;
    public int ActiveMemberCount { get; set; }
    public string[] Crest { get; set; } = null!;

    [JsonPropertyName("DC")] public string Dc { get; set; } = null!;

    public Estate? Estate { get; set; }
    public Focus[] Focus { get; set; } = null!;
    public int Formed { get; set; }
    public string GrandCompany { get; set; } = null!;

    [JsonPropertyName("ID")] public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;
    public int ParseDate { get; set; }
    public int Rank { get; set; }
    public Ranking Ranking { get; set; } = null!;
    public string Recruitment { get; set; } = null!;
    public Reputation[] Reputation { get; set; } = null!;
    public Seeking[] Seeking { get; set; } = null!;
    public string Server { get; set; } = null!;
    public string Slogan { get; set; } = null!;
    public string Tag { get; set; } = null!;
}