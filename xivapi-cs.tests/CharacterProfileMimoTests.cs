using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests;

public class CharacterProfileMimoTests
{
    [Test]
    public async Task GetAlyx()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28812634, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetLisa()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(32691240, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetHalvar()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28915387, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetFuoca()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(21201379, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetAlavel()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(30410250, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetEbih()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28025341, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetGenryu()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(3435267, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetKukuri()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(13951694, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetOne()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(28834908, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }

    [Test]
    public async Task GetRhayn()
    {
        var client = new XivApiClient();
        var result = await client.CharacterProfile(18188832, fetchMinionsMounts: true);
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result.Minions);
        Assert.IsNotEmpty(result.Mounts);
    }
}