using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileFcMembersTests
{
    [Test]
    public async Task GetAlyxAsync()
    {
        await TestFcMembersAsync(28812634, true);
    }

    [Test]
    public async Task GetLisaAsync()
    {
        await TestFcMembersAsync(32691240, true);
    }

    [Test]
    public async Task GetNinfixAsync()
    {
        await TestFcMembersAsync(2648055, true);
    }

    [Test]
    public async Task GetHalvarAsync()
    {
        await TestFcMembersAsync(28915387, true);
    }

    [Test]
    public async Task GetFuocaAsync()
    {
        await TestFcMembersAsync(21201379, true);
    }

    [Test]
    public async Task GetHenaAsync()
    {
        await TestFcMembersAsync(28835226, false);
    }

    [Test]
    public async Task GetEbihAsync()
    {
        await TestFcMembersAsync(28025341, true);
    }

    [Test]
    public async Task GetGenryuAsync()
    {
        await TestFcMembersAsync(3435267, true);
    }

    [Test]
    public async Task GetOneAsync()
    {
        await TestFcMembersAsync(28834908, false);
    }

    [Test]
    public async Task GetRhaynAsync()
    {
        await TestFcMembersAsync(18188832, true);
    }

    [Test]
    public async Task GetTestMaxAsync()
    {
        await TestFcMembersAsync(45386124, false);
    }

    private static async Task TestFcMembersAsync(int id, bool hasFc)
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