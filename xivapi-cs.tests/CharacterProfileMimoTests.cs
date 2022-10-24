using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Models;

namespace xivapi_cs.tests;

public class CharacterProfileMimoTests
{
    [Test]
    public async Task GetAlyx()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28812634, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetLisa()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(32691240, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetHalvar()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28915387, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetFuoca()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(21201379, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetAlavel()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(30410250, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetEbih()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28025341, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetGenryu()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(3435267, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetKukuri()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(13951694, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetOne()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28834908, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetRhayn()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(18188832, new CharacterProfileOptions(fetchMinionsMounts: true));
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }
}