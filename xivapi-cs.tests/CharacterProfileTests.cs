using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests
{
    public class GetCharacterTests
    {
        [Test]
        public async Task GetAlyx()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28812634);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetLisa()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(32691240);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetHalvar()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28915387);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetFuoca()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(21201379);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetHena()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28835226);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetAlavel()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(30410250);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEbih()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28025341);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetGenryu()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(3435267);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetKukuri()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(13951694);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetOne()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28834908);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetRhayn()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(18188832);
            Assert.IsNotNull(result);
        }
    }
}