using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileMimoTests
{
    [Test]
    public async Task GetAlyx()
    {
        await TestMimo(28812634);
    }

    [Test]
    public async Task GetLisa()
    {
        await TestMimo(32691240);
    }

    [Test]
    public async Task GetNinfix()
    {
        await TestMimo(2648055);
    }

    [Test]
    public async Task GetHalvar()
    {
        await TestMimo(28915387);
    }

    [Test]
    public async Task GetFuoca()
    {
        await TestMimo(21201379);
    }

    [Test]
    public async Task GetEbih()
    {
        await TestMimo(28025341);
    }

    [Test]
    public async Task GetGenryu()
    {
        await TestMimo(3435267);
    }

    [Test]
    public async Task GetOne()
    {
        await TestMimo(28834908);
    }

    [Test]
    public async Task GetRhayn()
    {
        await TestMimo(18188832);
    }

    [Test]
    public async Task GetTestMax()
    {
        await TestMimo(45386124, false, false);
    }

    private static async Task TestMimo(int id, bool hasMinions = true, bool hasMounts = true)
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(id, CharacterProfileOptions.MinionsMounts);
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