namespace xivapi_cs.DTOs.CharacterProfile;

public class CharacterProfileBase
{
    // FR
    public CharacterShort[]? Friends { get; init; }
    public bool? FriendsPublic { get; init; }

    // FC
    public FreeCompany? FreeCompany { get; init; }

    // FCM
    public CharacterShort[]? FreeCompanyMembers { get; init; }

    // MIMO
    public Pet[]? Minions { get; init; }
    public Pet[]? Mounts { get; init; }
}