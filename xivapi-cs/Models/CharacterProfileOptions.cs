namespace xivapi_cs.Models;

public class CharacterProfileOptions
{
    public readonly bool FetchAchievements;
    public readonly bool FetchFreeCompany;
    public readonly bool FetchFreeCompanyMembers;
    public readonly bool FetchFriends;
    public readonly bool FetchMinionsMounts;

    internal CharacterProfileOptions()
    {
    }

    public CharacterProfileOptions(bool fetchAchievements = false,
        bool fetchFriends = false,
        bool fetchFreeCompany = false,
        bool fetchFreeCompanyMembers = false,
        bool fetchMinionsMounts = false)
    {
        FetchAchievements = fetchAchievements;
        FetchFriends = fetchFriends;
        FetchFreeCompany = fetchFreeCompany;
        FetchFreeCompanyMembers = fetchFreeCompanyMembers;
        FetchMinionsMounts = fetchMinionsMounts;
    }
}