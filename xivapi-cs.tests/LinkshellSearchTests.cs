using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class LinkshellSearchTests
{
    [Test]
    public async Task SearchOdin()
    {
        var client = new XivApiClient();
        var result = await client.SearchLinkshellRegularAsync("Odin");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchOdinAndComparePagesAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchLinkshellRegularAsync("Odin");
        var result2 = await client.SearchLinkshellRegularAsync("Odin", 2);
        Assert.IsNotNull(result);
        Assert.IsNotNull(result2);
        Assert.Greater(result.Results.Length, 0);
        Assert.Greater(result2.Results.Length, 0);
        Assert.AreNotEqual(result.Results, result2.Results);
    }

    [Test]
    public async Task SearchOdinCrossworldAndComparePagesAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchLinkshellCrossworldAsync("Odin");
        var result2 = await client.SearchLinkshellCrossworldAsync("Odin", 2);
        Assert.IsNotNull(result);
        Assert.IsNotNull(result2);
        Assert.Greater(result.Results.Length, 0);
        Assert.Greater(result2.Results.Length, 0);
        Assert.AreNotEqual(result.Results, result2.Results);
    }

    [Test]
    public async Task SearchOdinPhoenixAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchLinkshellRegularAsync("Odin", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }
}