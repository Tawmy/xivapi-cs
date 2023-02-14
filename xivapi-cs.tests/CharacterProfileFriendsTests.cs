using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileFriendsTests
{
    [Test]
    public async Task GetAlyx()
    {
        await TestFriends(28812634);
    }

    [Test]
    public async Task GetLisa()
    {
        await TestFriends(32691240);
    }

    [Test]
    public async Task GetNinfix()
    {
        await TestFriends(2648055);
    }

    [Test]
    public async Task GetHalvar()
    {
        await TestFriends(28915387);
    }

    [Test]
    public async Task GetFuoca()
    {
        await TestFriends(21201379);
    }

    [Test]
    public async Task GetHena()
    {
        await TestFriends(28835226);
    }

    [Test]
    public async Task GetFizz()
    {
        await TestFriends(8696725);
    }

    [Test]
    public async Task GetEbih()
    {
        await TestFriends(28025341);
    }

    [Test]
    public async Task GetGenryu()
    {
        await TestFriends(3435267);
    }

    [Test]
    public async Task GetOne()
    {
        await TestFriends(28834908);
    }

    [Test]
    public async Task GetRhayn()
    {
        await TestFriends(18188832);
    }

    [Test]
    public async Task GetTestMax()
    {
        await TestFriends(45386124, true);
    }

    private static async Task TestFriends(int id, bool mustBeEmpty = false)
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