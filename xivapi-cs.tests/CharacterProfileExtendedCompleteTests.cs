using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;
using xivapi_cs.ViewModels.CharacterProfile;

namespace xivapi_cs.tests;

public class CharacterProfileExtendedCompleteTests
{
    [Test]
    public async Task GetAlyx()
    {
        await TestProfileExtendedComplete(28812634);
    }

    [Test]
    public async Task GetLisa()
    {
        await TestProfileExtendedComplete(32691240);
    }

    [Test]
    public async Task GetHalvar()
    {
        await TestProfileExtendedComplete(28915387);
    }

    [Test]
    public async Task GetFuoca()
    {
        await TestProfileExtendedComplete(21201379);
    }

    [Test]
    public async Task GetHena()
    {
        await TestProfileExtendedComplete(28835226, assertMounts: false);
    }

    [Test]
    public async Task GetEbih()
    {
        await TestProfileExtendedComplete(28025341);
    }

    [Test]
    public async Task GetGenryu()
    {
        await TestProfileExtendedComplete(3435267);
    }

    [Test]
    public async Task GetOne()
    {
        await TestProfileExtendedComplete(28834908);
    }

    [Test]
    public async Task GetRhayn()
    {
        await TestProfileExtendedComplete(18188832);
    }

    [Test]
    public async Task GetTestMax()
    {
        var result = await TestProfileExtendedComplete(45386124, false, false);

        Assert.IsEmpty(result.Minions);
        Assert.IsEmpty(result.Mounts);
    }

    private async Task<CharacterProfileExtended> TestProfileExtendedComplete(int id, bool assertMinions = true,
        bool assertMounts = true)
    {
        var client = new XivApiClient();
        var result =
            await client.CharacterProfileExtended(id,
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
            Assert.IsNotEmpty(result.Friends);
        }

        if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId))
        {
            Assert.IsNotNull(result.FreeCompany);
            Assert.IsNotEmpty(result.FreeCompanyMembers);
        }

        if (assertMinions)
        {
            Assert.IsNotEmpty(result.Minions);
        }

        if (assertMounts)
        {
            Assert.IsNotEmpty(result.Mounts);
        }

        Assert.IsNotNull(result.Character.ActiveClassJob.Job.JobEnum);

        return result;
    }
}