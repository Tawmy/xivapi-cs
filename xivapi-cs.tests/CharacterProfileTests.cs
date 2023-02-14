using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class GetCharacterTests
{
    [Test]
    public async Task GetAlyx()
    {
        await TestProfile(28812634);
    }

    [Test]
    public async Task GetLisa()
    {
        await TestProfile(32691240);
    }

    [Test]
    public async Task GetHalvar()
    {
        await TestProfile(28915387);
    }

    [Test]
    public async Task GetFuoca()
    {
        await TestProfile(21201379);
    }

    [Test]
    public async Task GetHena()
    {
        await TestProfile(28835226);
    }

    [Test]
    public async Task GetEbih()
    {
        await TestProfile(28025341);
    }

    [Test]
    public async Task GetGenryu()
    {
        await TestProfile(3435267);
    }

    [Test]
    public async Task GetOne()
    {
        await TestProfile(28834908);
    }

    [Test]
    public async Task GetRhayn()
    {
        await TestProfile(18188832);
    }

    [Test]
    public async Task GetTestMax()
    {
        await TestProfile(45386124);
    }

    private static async Task TestProfile(int id)
    {
        var client = new XivApiClient();
        var result = await client.GetCharacterProfileAsync(id, CharacterProfileOptions.None);
        Assert.IsNotNull(result);
    }
}