using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests;

public class FreeCompanyProfileTests
{
    [Test]
    public async Task GetUnionAsync()
    {
        var client = new XivApiClient();
        var result = await client.GetFreeCompanyProfileAsync("9231253336202787185", false);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task GetUnionWithMembersAsync()
    {
        var client = new XivApiClient();
        var result = await client.GetFreeCompanyProfileAsync("9231253336202787185", true);
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.FreeCompanyMembers);
        Assert.Greater(result.FreeCompanyMembers.Length, 0);
    }
}