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
            var result = await client.CharacterSearch("Alyx", "Bergen", "Phoenix");
            Assert.IsNotNull(result);
        }
        
        [Test]
        public async Task SearchAlyxDirect()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Alyx Bergen", "Phoenix");
            Assert.IsNotNull(result);
        }
        
        [Test]
        public async Task SearchLisa()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Lisa", "Bergen", "Phoenix");
            Assert.IsNotNull(result);
        }
        
        [Test]
        public async Task SearchHalvar()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Halvar", "Ragnar", "Phoenix");
            Assert.IsNotNull(result);
        }
        
        [Test]
        public async Task SearchGibberish()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("fasklhflask", "akshflksaf", "faslkfhka");
            Assert.IsNotNull(result);
        }
        
        [Test]
        public async Task SearchAlyxWrongServer()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Alyx", "Bergen", "Zodiark");
            Assert.IsNotNull(result);
        }
        
        [Test]
        public async Task SearchHena()
        {
            var client = new XivApiClient();
            var result = await client.CharacterSearch("Hena", "Wilbert", "Phoenix");
            Assert.IsNotNull(result);
        }
    }
}