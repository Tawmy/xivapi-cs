using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileExtendedCompleteTests
{
    [Test]
    public async Task GetAlyx()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(28812634,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetLisa()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(32691240,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetHalvar()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(28915387,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetFuoca()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(21201379,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetHena()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(28835226,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        // Mounts not asserted as user does not have any
    }

    [Test]
    public async Task GetAlavel()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(30410250,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetEbih()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(28025341,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetGenryu()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(3435267,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetKukuri()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(13951694,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetOne()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(28834908,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }

    [Test]
    public async Task GetRhayn()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(18188832,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotNull(result.FreeCompanyMembers);
        }

        Assert.IsNotNull(result.Minions);
        Assert.IsNotNull(result.Mounts);
    }
    
    [Test]
    public async Task GetTestMax()
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(45386124,
                CharacterProfileOptions.Achievements |
                CharacterProfileOptions.Friends |
                CharacterProfileOptions.FreeCompany |
                CharacterProfileOptions.FreeCompanyMembers |
                CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.IsNotEmpty(result.Achievements.List);
        }

        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.IsNotEmpty(result.Friends);
        }

        Assert.IsNull(result.Character.FreeCompanyId);

        Assert.IsEmpty(result.Minions);
        Assert.IsEmpty(result.Mounts);
    }
}