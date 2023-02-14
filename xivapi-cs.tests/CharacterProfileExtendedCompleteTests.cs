using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;
using xivapi_cs.ViewModels.CharacterProfile;

namespace xivapi_cs.tests;

public class CharacterProfileExtendedCompleteTests
{
    [Test]
    public async Task GetAlyxAsync()
    {
        await TestProfileExtendedCompleteAsync(28812634);
    }

    [Test]
    public async Task GetLisaAsync()
    {
        await TestProfileExtendedCompleteAsync(32691240);
    }

    [Test]
    public async Task GetNinfixAsync()
    {
        await TestProfileExtendedCompleteAsync(2648055);
    }

    [Test]
    public async Task GetHalvarAsync()
    {
        await TestProfileExtendedCompleteAsync(28915387);
    }

    [Test]
    public async Task GetFuocaAsync()
    {
        await TestProfileExtendedCompleteAsync(21201379);
    }

    [Test]
    public async Task GetHenaAsync()
    {
        await TestProfileExtendedCompleteAsync(28835226, assertMounts: false);
    }

    [Test]
    public async Task GetEbihAsync()
    {
        await TestProfileExtendedCompleteAsync(28025341);
    }

    [Test]
    public async Task GetGenryuAsync()
    {
        await TestProfileExtendedCompleteAsync(3435267);
    }

    [Test]
    public async Task GetOneAsync()
    {
        await TestProfileExtendedCompleteAsync(28834908);
    }

    [Test]
    public async Task GetRhaynAsync()
    {
        await TestProfileExtendedCompleteAsync(18188832);
    }

    [Test]
    public async Task GetTestMaxAsync()
    {
        var result = await TestProfileExtendedCompleteAsync(45386124, false, false);

        Assert.IsEmpty(result.Minions);
        Assert.IsEmpty(result.Mounts);
    }

    private static async Task<CharacterProfileExtended> TestProfileExtendedCompleteAsync(int id,
        bool assertMinions = true, bool assertMounts = true)
    {
        var client = new XivApiClient();
        var result =
            await client.GetCharacterProfileExtendedAsync(id,
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
        Assert.IsNotNull(result.Character.GearSet.Gear.AverageItemLevel);

        return result;
    }
}