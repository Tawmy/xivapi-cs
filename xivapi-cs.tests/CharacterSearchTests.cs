using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests
{
    public class CharacterSearchTests
    {
        [Test]
        public async Task SearchAlyx()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Alyx Bergen", "Phoenix");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchLisa()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Lisa Bergen", "Phoenix");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchHalvar()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Halvar Ragnar", "Phoenix");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public void SearchGibberish()
        {
            var client = new XivApiClient();
            Assert.ThrowsAsync<ArgumentException>(async () => 
                await client.CharacterSearch("fasklhflaskakshflksaf", "faslkfhka"));
        }

        [Test]
        public async Task SearchAlyxWrongServer()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Alyx Bergen", "Zodiark");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task SearchAlyxNoServer()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Alyx Bergen");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchHena()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Hena Wilbert", "Phoenix");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchOdin()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Odin");
            Assert.IsNotNull(result);
            Assert.Greater(result.Results.Length, 0);
        }

        [Test]
        public async Task SearchOdinAndComparePages()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Odin");
            var result2 = await client.CharacterSearch("Odin", page: 2);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result2);
            Assert.Greater(result.Results.Length, 0);
            Assert.Greater(result2.Results.Length, 0);
            Assert.AreNotEqual(result.Results, result2.Results);
        }
    }
}