using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class CharacterProfile : CharacterProfileBase
{
    // AC
    internal CharacterProfile(DTOs.CharacterProfile.CharacterProfile dto) : base(dto)
    {
        if (dto.Achievements != null)
        {
            Achievements = new Achievements(dto.Achievements);
        }

        // fallback workaround since AchievementsPublic seems to always be null
        AchievementsPublic = dto.AchievementsPublic != null
            ? AchievementsPublic
            : dto.Achievements?.List.Any() == true;

        Character = new Character(dto.Character);
    }

    public Achievements? Achievements { get; }
    public bool AchievementsPublic { get; }

    // default
    public Character Character { get; }
}