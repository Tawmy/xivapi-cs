using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class AchievementsExtended : AchievementsBase
{
    internal AchievementsExtended(DTOs.CharacterProfile.AchievementsExtended dto) : base(dto)
    {
        List = dto.List.Select(x => new AchievementExtended(x)).ToArray();
    }

    public AchievementExtended[] List { get; }
}