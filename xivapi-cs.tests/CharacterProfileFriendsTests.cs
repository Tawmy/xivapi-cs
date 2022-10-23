using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests;

public class CharacterProfileFriendsTests
{
    [Test]
    public async Task GetAlyx()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28812634, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetLisa()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(32691240, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetHalvar()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28915387, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetFuoca()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(21201379, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetHena()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28835226, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetFizz()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(8696725, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetEbih()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28025341, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetGenryu()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(3435267, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetKukuri()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(13951694, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetOne()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28834908, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }

    [Test]
    public async Task GetRhayn()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(18188832, fetchFriends: true);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }
}