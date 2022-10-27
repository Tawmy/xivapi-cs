using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterProfileFriendsTests
{
    [Test]
    public async Task GetAlyx()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28812634, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(32691240, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(28915387, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(21201379, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(28835226, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(8696725, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(28025341, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(3435267, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(13951694, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(28834908, CharacterProfileOptions.Friends);
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
        var result = await client.CharacterProfile(18188832, CharacterProfileOptions.Friends);
        Assert.IsNotNull(result);
        if (result.FriendsPublic)
        {
            Assert.IsNotNull(result.Friends);
            Assert.Greater(result.Friends.Length, 0);
        }
    }
    
    [Test]
    public async Task GetTestMax()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(45386124, CharacterProfileOptions.Friends);
        Assert.IsNotNull(result);
        Assert.IsEmpty(result.Friends);
    }
}