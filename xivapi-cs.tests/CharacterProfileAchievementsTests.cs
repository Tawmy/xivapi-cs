using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileAchievementsTests
{
    [Test]
    public async Task GetAlyx()
    {
        await TestAchievements(28812634);
    }

    [Test]
    public async Task GetLisa()
    {
        await TestAchievements(32691240);
    }

    [Test]
    public async Task GetHalvar()
    {
        await TestAchievements(28915387);
    }

    [Test]
    public async Task GetFuoca()
    {
        await TestAchievements(21201379);
    }

    [Test]
    public async Task GetHena()
    {
        await TestAchievements(28835226);
    }

    [Test]
    public async Task GetEbih()
    {
        await TestAchievements(28025341);
    }

    [Test]
    public async Task GetGenryu()
    {
        await TestAchievements(3435267);
    }

    [Test]
    public async Task GetOne()
    {
        await TestAchievements(28834908);
    }

    [Test]
    public async Task GetRhayn()
    {
        await TestAchievements(18188832);
    }
    
    [Test]
    public async Task GetTestMax()
    {
        await TestAchievements(45386124);
    }

    private async Task TestAchievements(int id)
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(id, CharacterProfileOptions.Achievements);
        Assert.IsNotNull(result);
        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.Greater(result.Achievements.List.Length, 0);
        }
    }
}