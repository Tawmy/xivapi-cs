using System.Threading.Tasks;
using NUnit.Framework;
using xivapi_cs.Enums;

namespace xivapi_cs.tests;

public class FreeCompanySearchTests
{
    [Test]
    public async Task SearchUnion()
    {
        var client = new XivApiClient();
        var result = await client.FreeCompanySearch("Union");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchUnionPhoenix()
    {
        var client = new XivApiClient();
        var result = await client.FreeCompanySearch("Union", HomeWorld.Phoenix);
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchAkadaemiaEorzea()
    {
        var client = new XivApiClient();
        var result = await client.FreeCompanySearch("Akadaemia Eorzea");
        Assert.IsNotNull(result);
        Assert.Greater(result.Results.Length, 0);
    }

    [Test]
    public async Task SearchGuildAndComparePages()
    {
        var client = new XivApiClient();
        var result = await client.FreeCompanySearch("Guild");
        var result2 = await client.FreeCompanySearch("Guild", 2);
        Assert.IsNotNull(result);
        Assert.IsNotNull(result2);
        Assert.Greater(result.Results.Length, 0);
        Assert.Greater(result2.Results.Length, 0);
        Assert.AreNotEqual(result.Results, result2.Results);
    }
}