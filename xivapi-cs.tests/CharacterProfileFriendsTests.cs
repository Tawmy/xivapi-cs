using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileFriendsTests
{
    [Test]
    public async Task GetAlyxAsync()
    {
        await TestFriendsAsync(28812634);
    }

    [Test]
    public async Task GetLisaAsync()
    {
        await TestFriendsAsync(32691240);
    }

    [Test]
    public async Task GetNinfixAsync()
    {
        await TestFriendsAsync(2648055);
    }

    [Test]
    public async Task GetHalvarAsync()
    {
        await TestFriendsAsync(28915387);
    }

    [Test]
    public async Task GetFuocaAsync()
    {
        await TestFriendsAsync(21201379);
    }

    [Test]
    public async Task GetHenaAsync()
    {
        await TestFriendsAsync(28835226);
    }

    [Test]
    public async Task GetFizzAsync()
    {
        await TestFriendsAsync(8696725);
    }

    [Test]
    public async Task GetEbihAsync()
    {
        await TestFriendsAsync(28025341);
    }

    [Test]
    public async Task GetGenryuAsync()
    {
        await TestFriendsAsync(3435267);
    }

    [Test]
    public async Task GetOneAsync()
    {
        await TestFriendsAsync(28834908);
    }

    [Test]
    public async Task GetRhaynAsync()
    {
        await TestFriendsAsync(18188832);
    }

    [Test]
    public async Task GetTestMaxAsync()
    {
        await TestFriendsAsync(45386124, true);
    }

    private static async Task TestFriendsAsync(int id, bool mustBeEmpty = false)
    {
        var client = new XivApiClient();
        var result = await client.GetCharacterProfileAsync(id, CharacterProfileOptions.Friends);
        Assert.IsNotNull(result);

        if (mustBeEmpty)
        {
            Assert.IsEmpty(result.Friends);
        }
        else if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }
}