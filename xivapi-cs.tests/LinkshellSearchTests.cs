using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests
{
    public class LinkshellSearchTests
    {
        [Test]
        public async Task SearchOdin()
        {
            var client = new XivApiClient();
            var result = await client.LinkshellSearch("Odin");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchOdinAndComparePages()
        {
            var client = new XivApiClient();
            var result = await client.LinkshellSearch("Odin");
            var result2 = await client.LinkshellSearch("Odin", page: 2);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result2);
            Assert.Greater(result.Results.Length, 0);
            Assert.Greater(result2.Results.Length, 0);
            Assert.AreNotEqual(result.Results, result2.Results);
        }

        [Test]
        public async Task SearchOdinPhoenix()
        {
            var client = new XivApiClient();
            var result = await client.LinkshellSearch("Odin", "Phoenix");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchOdinGibberishServer()
        {
            var client = new XivApiClient();
            var result = await client.LinkshellSearch("Odin", "fhaskjlhfajkshf");
            Assert.IsNull(result);
        }
    }
}