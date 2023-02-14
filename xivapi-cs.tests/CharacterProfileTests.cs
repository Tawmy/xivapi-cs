using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class GetCharacterTests
{
    [Test]
    public async Task GetAlyxAsync()
    {
        await TestProfileAsync(28812634);
    }

    [Test]
    public async Task GetLisaAsync()
    {
        await TestProfileAsync(32691240);
    }

    [Test]
    public async Task GetHalvarAsync()
    {
        await TestProfileAsync(28915387);
    }

    [Test]
    public async Task GetFuocaAsync()
    {
        await TestProfileAsync(21201379);
    }

    [Test]
    public async Task GetHenaAsync()
    {
        await TestProfileAsync(28835226);
    }

    [Test]
    public async Task GetEbihAsync()
    {
        await TestProfileAsync(28025341);
    }

    [Test]
    public async Task GetGenryuAsync()
    {
        await TestProfileAsync(3435267);
    }

    [Test]
    public async Task GetOneAsync()
    {
        await TestProfileAsync(28834908);
    }

    [Test]
    public async Task GetRhaynAsync()
    {
        await TestProfileAsync(18188832);
    }

    [Test]
    public async Task GetTestMaxAsync()
    {
        await TestProfileAsync(45386124);
    }

    private static async Task TestProfileAsync(int id)
    {
        var client = new XivApiClient();
        var result = await client.GetCharacterProfileAsync(id, CharacterProfileOptions.None);
        Assert.IsNotNull(result);
    }
}