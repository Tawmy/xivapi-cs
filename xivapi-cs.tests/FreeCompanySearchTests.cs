using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests
{
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
            var result = await client.FreeCompanySearch("Union", "Phoenix");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchAkadaemiaEorzeanum()
        {
            var client = new XivApiClient();
            var result = await client.FreeCompanySearch("Akadaemia Eorzeanum");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchGuildAndComparePages()
        {
            var client = new XivApiClient();
            var result = await client.FreeCompanySearch("Guild");
            var result2 = await client.FreeCompanySearch("Guild", page: 2);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result2);
            Assert.Greater(result.Results.Length, 0);
            Assert.Greater(result2.Results.Length, 0);
            Assert.AreNotEqual(result.Results, result2.Results);
        }
    }
}