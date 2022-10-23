using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class CharacterExtended : CharacterBase
{
    public CharacterExtended(DTOs.CharacterProfile.CharacterExtended dto) : base(dto)
    {
        ActiveClassJob = new ClassJobExtended(dto.ActiveClassJob);
        ClassJobs = dto.ClassJobs.Select(x => new ClassJobExtended(x)).ToArray();
        GearSet = new GearSetExtended(dto.GearSet);
        GenderId = dto.GenderId;

        if (dto.GrandCompany?.Company != null)
        {
            GrandCompany = new GrandCompanyExtended(dto.GrandCompany);
        }

        GuardianDeity = new GuardianDeity(dto.GuardianDeity);
        Race = new UrlAttribute(dto.Race);
        Title = new IconUrlAttribute(dto.Title);
        Town = new IconUrlAttribute(dto.Town);
        Tribe = new IconUrlAttribute(dto.Tribe);
    }

    public ClassJobExtended ActiveClassJob { get; }
    public ClassJobExtended[] ClassJobs { get; }
    public GearSetExtended GearSet { get; }
    public int GenderId { get; }
    public GrandCompanyExtended? GrandCompany { get; }
    public GuardianDeity GuardianDeity { get; }
    public UrlAttribute Race { get; }
    public IconUrlAttribute Title { get; }
    public IconUrlAttribute Town { get; }
    public IconUrlAttribute Tribe { get; }
}