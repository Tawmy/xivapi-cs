using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class AchievementsExtended : AchievementsBase
    {
        public AchievementsExtended(DTOs.CharacterProfile.AchievementsExtended dto) : base(dto)
        {
            List = dto.List.Select(x => new AchievementExtended(x)).ToArray();
        }

        public AchievementExtended[] List { get; }
    }
}