using System;
using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class CharacterProfileBase
{
    // FR
    public CharacterProfileBase(DTOs.CharacterProfile.CharacterProfileBase dto)
    {
        if (dto.Friends != null)
        {
            Friends = dto.Friends.Select(x => new CharacterShort(x)).ToArray();
        }

        // fallback workaround since FriendsPublic seems to always be null
        FriendsPublic = dto.FriendsPublic != null
            ? FriendsPublic
            : Friends.Any();

        if (dto.FreeCompany != null)
        {
            FreeCompany = new FreeCompany(dto.FreeCompany);
        }

        if (dto.FreeCompanyMembers != null)
        {
            FreeCompanyMembers = dto.FreeCompanyMembers.Select(x => new CharacterShort(x)).ToArray();
        }

        if (dto.Minions != null)
        {
            Minions = dto.Minions.Select(x => new Pet(x)).ToArray();
        }

        if (dto.Mounts != null)
        {
            Mounts = dto.Mounts.Select(x => new Pet(x)).ToArray();
        }
    }

    public CharacterShort[] Friends { get; } = Array.Empty<CharacterShort>();
    public bool FriendsPublic { get; }

    // FC
    public FreeCompany? FreeCompany { get; }

    // FCM
    public CharacterShort[] FreeCompanyMembers { get; } = Array.Empty<CharacterShort>();

    // MIMO
    public Pet[] Minions { get; } = Array.Empty<Pet>();
    public Pet[] Mounts { get; } = Array.Empty<Pet>();
}