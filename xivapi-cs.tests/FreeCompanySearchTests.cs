using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class FreeCompanySearchTests
{
    [Test]
    public async Task SearchUnionAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchFreeCompanyAsync("Union");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchUnionPhoenixAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchFreeCompanyAsync("Union", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchAkadaemiaEorzeaAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchFreeCompanyAsync("Akadaemia Eorzea");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchGuildAndComparePagesAsync()
    {
        var client = new XivApiClient();
        var result = await client.SearchFreeCompanyAsync("Guild");
        var result2 = await client.SearchFreeCompanyAsync("Guild", 2);
        Assert.IsNotNull(result);
        Assert.IsNotNull(result2);
        Assert.Greater(result.Results.Length, 0);
        Assert.Greater(result2.Results.Length, 0);
        Assert.AreNotEqual(result.Results, result2.Results);
    }
}