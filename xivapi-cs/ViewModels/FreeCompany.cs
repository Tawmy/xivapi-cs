using System.Linq;
using xivapi_cs.ViewModels.CharacterProfile;

namespace xivapi_cs.ViewModels;

public class FreeCompany
{
    public FreeCompany(DTOs.FreeCompany dto)
    {
        Active = dto.Active;
        ActiveMemberCount = dto.ActiveMemberCount;
        Crest = dto.Crest;
        Dc = dto.Dc;
        Estate = new Estate(dto.Estate);
        Focus = dto.Focus.Select(x => new Focus(x)).ToArray();
        Formed = dto.Formed;
        GrandCompany = dto.GrandCompany;
        Id = dto.Id;
        Name = dto.Name;
        ParseDate = dto.ParseDate;
        Rank = dto.Rank;
        Ranking = new Ranking(dto.Ranking);
        Recruitment = dto.Recruitment;
        Reputation = dto.Reputation.Select(x => new Reputation(x)).ToArray();
        Seeking = dto.Seeking.Select(x => new Seeking(x)).ToArray();
        Server = dto.Server;
        Slogan = dto.Slogan;
        Tag = dto.Tag;
    }

    public string Active { get; }
    public int ActiveMemberCount { get; }
    public string[] Crest { get; }

    public string Dc { get; }

    public Estate Estate { get; }
    public Focus[] Focus { get; }
    public int Formed { get; }
    public string GrandCompany { get; }
    public string Id { get; }
    public string Name { get; }
    public int ParseDate { get; }
    public int Rank { get; }
    public Ranking Ranking { get; }
    public string Recruitment { get; }
    public Reputation[] Reputation { get; }
    public Seeking[] Seeking { get; }
    public string Server { get; }
    public string Slogan { get; }
    public string Tag { get; }
}