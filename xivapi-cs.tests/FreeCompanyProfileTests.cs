using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests
{
    public class FreeCompanyProfileTests
    {
        [Test]
        public async Task GetUnion()
        {
            var client = new XivApiClient();
            var result = await client.FreeCompanyProfile("9231253336202787185");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetUnionWithMembers()
        {
            var client = new XivApiClient();
            var result = await client.FreeCompanyProfile("9231253336202787185", true);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.FreeCompanyMembers);
            Assert.Greater(result.FreeCompanyMembers.Length, 0);
        }
    }
}