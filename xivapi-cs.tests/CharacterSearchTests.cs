using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterSearchTests
{
    [Test]
    public async Task SearchAlyx()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Alyx Bergen", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchLisa()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Lisa Bergen", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchHalvar()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Halvar Ragnar", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchGibberish()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("fasklhflaskakshflksaf");
        Assert.IsNotNull(result);
        Assert.IsEmpty(result.Results);
    }

    [Test]
    public async Task SearchAlyxWrongServer()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Alyx Bergen", HomeWorld.Zodiark);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task SearchAlyxNoServer()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Alyx Bergen");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchHena()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Hena Wilbert", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchOdin()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Odin");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchOdinAndComparePages()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Odin");
        var result2 = await client.CharacterSearch("Odin", 2);
        Assert.IsNotNull(result);
        Assert.IsNotNull(result2);
        Assert.Greater(result.Results.Length, 0);
        Assert.Greater(result2.Results.Length, 0);
        Assert.AreNotEqual(result.Results, result2.Results);
    }

    [Test]
    public async Task SearchTestMax()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Testerinus Maximus", HomeWorld.Twintania);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchTestMin()
    {
        var client = new XivApiClient();
        var result = await client.CharacterSearch("Testerinus Minimus");
        Assert.IsNotNull(result);
        Assert.AreEqual(0, 0);
    }
}