using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests;

public class LinkshellProfileTests
{
    [Test]
    public async Task GetRegularAsync()
    {
        var client = new XivApiClient();
        var result = await client.GetLinkshellProfileRegularAsync("11540474045161933");
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task GetCrossworldAsync()
    {
        var client = new XivApiClient();
        var result = await client.GetLinkshellProfileCrossworldAsync("b2f4cbcae4c10ea9f82b7234c4acf433eca95ba6");
        Assert.IsNotNull(result);
    }
}