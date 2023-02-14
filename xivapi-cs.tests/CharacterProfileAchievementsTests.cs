using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileAchievementsTests
{
    [Test]
    public async Task GetAlyxAsync()
    {
        await TestAchievementsAsync(28812634);
    }

    [Test]
    public async Task GetLisaAsync()
    {
        await TestAchievementsAsync(32691240);
    }

    [Test]
    public async Task GetNinfixAsync()
    {
        await TestAchievementsAsync(2648055);
    }

    [Test]
    public async Task GetHalvarAsync()
    {
        await TestAchievementsAsync(28915387);
    }

    [Test]
    public async Task GetFuocaAsync()
    {
        await TestAchievementsAsync(21201379);
    }

    [Test]
    public async Task GetHenaAsync()
    {
        await TestAchievementsAsync(28835226);
    }

    [Test]
    public async Task GetEbihAsync()
    {
        await TestAchievementsAsync(28025341);
    }

    [Test]
    public async Task GetGenryuAsync()
    {
        await TestAchievementsAsync(3435267);
    }

    [Test]
    public async Task GetOneAsync()
    {
        await TestAchievementsAsync(28834908);
    }

    [Test]
    public async Task GetRhaynAsync()
    {
        await TestAchievementsAsync(18188832);
    }

    [Test]
    public async Task GetTestMaxAsync()
    {
        await TestAchievementsAsync(45386124);
    }

    private static async Task TestAchievementsAsync(int id)
    {
        var client = new XivApiClient();
        var result = await client.GetCharacterProfileAsync(id, CharacterProfileOptions.Achievements);
        Assert.IsNotNull(result);
        if (result.AchievementsPublic)
        {
            Assert.IsNotNull(result.Achievements);
            Assert.Greater(result.Achievements.List.Length, 0);
        }
    }
}