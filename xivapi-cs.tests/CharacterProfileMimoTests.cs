using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileMimoTests
{
    [Test]
    public async Task GetAlyxAsync()
    {
        await TestMimoAsync(28812634);
    }

    [Test]
    public async Task GetLisaAsync()
    {
        await TestMimoAsync(32691240);
    }

    [Test]
    public async Task GetNinfixAsync()
    {
        await TestMimoAsync(2648055);
    }

    [Test]
    public async Task GetHalvarAsync()
    {
        await TestMimoAsync(28915387);
    }

    [Test]
    public async Task GetFuocaAsync()
    {
        await TestMimoAsync(21201379);
    }

    [Test]
    public async Task GetEbihAsync()
    {
        await TestMimoAsync(28025341);
    }

    [Test]
    public async Task GetGenryuAsync()
    {
        await TestMimoAsync(3435267);
    }

    [Test]
    public async Task GetOneAsync()
    {
        await TestMimoAsync(28834908);
    }

    [Test]
    public async Task GetRhaynAsync()
    {
        await TestMimoAsync(18188832);
    }

    [Test]
    public async Task GetTestMaxAsync()
    {
        await TestMimoAsync(45386124, false, false);
    }

    private static async Task TestMimoAsync(int id, bool hasMinions = true, bool hasMounts = true)
    {
        var client = new XivApiClient();
        var result = await client.GetCharacterProfileAsync(id, CharacterProfileOptions.MinionsMounts);
        Assert.IsNotNull(result);

        if (hasMinions)
        {
            Assert.IsNotEmpty(result.Minions);
            Assert.IsNotNull(result.MinionPercentage);
        }
        else
        {
            Assert.IsEmpty(result.Minions);
        }

        if (hasMounts)
        {
            Assert.IsNotEmpty(result.Mounts);
            Assert.IsNotNull(result.MountPercentage);
        }
        else
        {
            Assert.IsEmpty(result.Mounts);
        }
    }
}