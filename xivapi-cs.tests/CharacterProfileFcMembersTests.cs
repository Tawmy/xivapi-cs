using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileFcMembersTests
{
    [Test]
    public async Task GetAlyx()
    {
        await TestFcMembers(28812634, true);
    }

    [Test]
    public async Task GetLisa()
    {
        await TestFcMembers(32691240, true);
    }

    [Test]
    public async Task GetNinfix()
    {
        await TestFcMembers(2648055, true);
    }

    [Test]
    public async Task GetHalvar()
    {
        await TestFcMembers(28915387, true);
    }

    [Test]
    public async Task GetFuoca()
    {
        await TestFcMembers(21201379, true);
    }

    [Test]
    public async Task GetHena()
    {
        await TestFcMembers(28835226, false);
    }

    [Test]
    public async Task GetEbih()
    {
        await TestFcMembers(28025341, true);
    }

    [Test]
    public async Task GetGenryu()
    {
        await TestFcMembers(3435267, true);
    }

    [Test]
    public async Task GetOne()
    {
        await TestFcMembers(28834908, false);
    }

    [Test]
    public async Task GetRhayn()
    {
        await TestFcMembers(18188832, true);
    }

    [Test]
    public async Task GetTestMax()
    {
        await TestFcMembers(45386124, false);
    }

    private static async Task TestFcMembers(int id, bool hasFc)
    {
        var client = new XivApiClient();
        var result = await client.GetCharacterProfileAsync(id, CharacterProfileOptions.FreeCompanyMembers);
        Assert.IsNotNull(result);

        if (hasFc)
        {
            Assert.IsNotNull(result.Character.FreeCompanyId);
            Assert.IsNotEmpty(result.FreeCompanyMembers);
        }
        else
        {
            Assert.IsNull(result.Character.FreeCompanyId);
            Assert.IsEmpty(result.FreeCompanyMembers);
        }
    }
}