using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class Achievements : AchievementsBase
{
    internal Achievements(DTOs.CharacterProfile.Achievements dto) : base(dto)
    {
        List = dto.List.Select(x => new Achievement(x)).ToArray();
    }

    public Achievement[] List { get; }
}