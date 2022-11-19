using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileFcTests
{
    [Test]
    public async Task GetAlyx()
    {
        await TestFc(28812634, true);
    }

    [Test]
    public async Task GetLisa()
    {
        await TestFc(32691240, true);
    }

    [Test]
    public async Task GetNinfix()
    {
        await TestFc(2648055, true);
    }

    [Test]
    public async Task GetHalvar()
    {
        await TestFc(28915387, true);
    }

    [Test]
    public async Task GetFuoca()
    {
        await TestFc(21201379, true);
    }

    [Test]
    public async Task GetHena()
    {
        await TestFc(28835226, false);
    }

    [Test]
    public async Task GetEbih()
    {
        await TestFc(28025341, true);
    }

    [Test]
    public async Task GetGenryu()
    {
        await TestFc(3435267, true);
    }

    [Test]
    public async Task GetOne()
    {
        await TestFc(28834908, false);
    }

    [Test]
    public async Task GetRhayn()
    {
        await TestFc(18188832, true);
    }

    [Test]
    public async Task GetTestMax()
    {
        await TestFc(45386124, false);
    }

    private static async Task TestFc(int id, bool hasFc)
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(id, CharacterProfileOptions.FreeCompany);
        Assert.IsNotNull(result);

        if (hasFc)
        {
            Assert.IsNotNull(result.Character.FreeCompanyId);
            Assert.IsNotNull(result.FreeCompany);
        }
        else
        {
            Assert.IsNull(result.Character.FreeCompanyId);
            Assert.IsNull(result.FreeCompany);
        }
    }
}