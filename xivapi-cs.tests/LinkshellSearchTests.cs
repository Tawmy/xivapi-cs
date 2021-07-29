using System;
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
            var result = await client.LinkshellSearchRegular("Odin");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchOdinAndComparePages()
        {
            var client = new XivApiClient();
            var result = await client.LinkshellSearchRegular("Odin");
            var result2 = await client.LinkshellSearchRegular("Odin", page: 2);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result2);
            Assert.Greater(result.Results.Length, 0);
            Assert.Greater(result2.Results.Length, 0);
            Assert.AreNotEqual(result.Results, result2.Results);
        }

        [Test]
        public async Task SearchOdinCrossworldAndComparePages()
        {
            var client = new XivApiClient();
            var result = await client.LinkshellSearchCrossworld("Odin");
            var result2 = await client.LinkshellSearchCrossworld("Odin", 2);
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
            var result = await client.LinkshellSearchRegular("Odin", "Phoenix");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public void SearchOdinGibberishServer()
        {
            var client = new XivApiClient();
            Assert.ThrowsAsync<ArgumentException>(
                async () => await client.LinkshellSearchRegular("Odin", "fhaskjlhfajkshf"));
        }
    }
}