using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileFcTests
{
    [Test]
    public async Task GetAlyxAsync()
    {
        await TestFcAsync(28812634, true);
    }

    [Test]
    public async Task GetLisaAsync()
    {
        await TestFcAsync(32691240, true);
    }

    [Test]
    public async Task GetNinfixAsync()
    {
        await TestFcAsync(2648055, true);
    }

    [Test]
    public async Task GetHalvarAsync()
    {
        await TestFcAsync(28915387, true);
    }

    [Test]
    public async Task GetFuocaAsync()
    {
        await TestFcAsync(21201379, true);
    }

    [Test]
    public async Task GetHenaAsync()
    {
        await TestFcAsync(28835226, false);
    }

    [Test]
    public async Task GetEbihAsync()
    {
        await TestFcAsync(28025341, true);
    }

    [Test]
    public async Task GetGenryuAsync()
    {
        await TestFcAsync(3435267, true);
    }

    [Test]
    public async Task GetOneAsync()
    {
        await TestFcAsync(28834908, false);
    }

    [Test]
    public async Task GetRhaynAsync()
    {
        await TestFcAsync(18188832, true);
    }

    [Test]
    public async Task GetTestMaxAsync()
    {
        await TestFcAsync(45386124, false);
    }

    private static async Task TestFcAsync(int id, bool hasFc)
    {
        var client = new XivApiClient();
        var result = await client.GetCharacterProfileAsync(id, CharacterProfileOptions.FreeCompany);
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