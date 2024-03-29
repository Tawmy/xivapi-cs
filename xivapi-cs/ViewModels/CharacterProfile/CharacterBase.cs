using xivapi_cs.Models;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class CharacterBase : Attribute
{
    internal CharacterBase(DTOs.CharacterProfile.CharacterBase dto) : base(dto)
    {
        Avatar = dto.Avatar;
        Bio = dto.Bio;
        ClassJobsBozjan = new ClassJobsBozjan(dto.ClassJobsBozjan);
        ClassJobsElemental = new ClassJobsElemental(dto.ClassJobsElemental);
        Dc = dto.Dc;
        FreeCompanyId = dto.FreeCompanyId;
        FreeCompanyName = dto.FreeCompanyName;
        Gender = dto.Gender;
        Lang = dto.Lang;
        Nameday = dto.Nameday;
        ParseDate = dto.ParseDate;
        Portrait = dto.Portrait;
        PvPTeamId = dto.PvPTeamId;
        HomeWorld = new HomeWorldDetails(dto.Server);
        TitleTop = dto.TitleTop;
    }

    public string Avatar { get; }
    public string Bio { get; }
    public ClassJobsBozjan ClassJobsBozjan { get; }
    public ClassJobsElemental ClassJobsElemental { get; }

    public string Dc { get; }

    public string? FreeCompanyId { get; }
    public string? FreeCompanyName { get; }
    public int Gender { get; }
    public object? Lang { get; } // no clue, seems to always be null
    public string Nameday { get; }
    public int ParseDate { get; }
    public string Portrait { get; }
    public int? PvPTeamId { get; }
    public HomeWorldDetails HomeWorld { get; }
    public bool TitleTop { get; }
}