using System.Text.Json.Serialization;
using xivapi_cs.DTOs.CharacterProfile;

namespace xivapi_cs.DTOs;

public class FreeCompany
{
    public string Active { get; set; }
    public int ActiveMemberCount { get; set; }
    public string[] Crest { get; set; }

    [JsonPropertyName("DC")] public string Dc { get; set; }

    public Estate Estate { get; set; }
    public Focus[] Focus { get; set; }
    public int Formed { get; set; }
    public string GrandCompany { get; set; }

    [JsonPropertyName("ID")] public string Id { get; set; }

    public string Name { get; set; }
    public int ParseDate { get; set; }
    public int Rank { get; set; }
    public Ranking Ranking { get; set; }
    public string Recruitment { get; set; }
    public Reputation[] Reputation { get; set; }
    public Seeking[] Seeking { get; set; }
    public string Server { get; set; }
    public string Slogan { get; set; }
    public string Tag { get; set; }
}