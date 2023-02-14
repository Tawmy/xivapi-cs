using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class CharacterSearchTests
{
    [Test]
    public async Task SearchAlyxAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Alyx Bergen", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchLisaAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Lisa Bergen", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchHalvarAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Halvar Ragnar", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchGibberishAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("fasklhflaskakshflksaf");
        Assert.IsNotNull(result);
        Assert.IsEmpty(result.Results);
    }

    [Test]
    public async Task SearchAlyxWrongServerAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Alyx Bergen", HomeWorld.Zodiark);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task SearchAlyxNoServerAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Alyx Bergen");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchHenaAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Hena Wilbert", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchOdinAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Odin");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchOdinAndComparePagesAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Odin");
        var result2 = await client.SearchCharacterAsync("Odin", 2);
        Assert.IsNotNull(result);
        Assert.IsNotNull(result2);
        Assert.Greater(result.Results.Length, 0);
        Assert.Greater(result2.Results.Length, 0);
        Assert.AreNotEqual(result.Results, result2.Results);
    }

    [Test]
    public async Task SearchTestMaxAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Testerinus Maximus", HomeWorld.Twintania);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchTestMinAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchCharacterAsync("Testerinus Minimus");
        Assert.IsNotNull(result);
        Assert.AreEqual(0, 0);
    }
}