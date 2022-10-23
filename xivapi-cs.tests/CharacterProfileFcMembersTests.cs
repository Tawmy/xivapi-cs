using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests
{
    public class CharacterProfileFcMembersTests
    {
        [Test]
        public async Task GetAlyx()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28812634, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetLisa()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(32691240, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetHalvar()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28915387, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetFuoca()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(21201379, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetHena()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28835226, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            Assert.IsNull(result.Character.FreeCompanyId);
            Assert.IsEmpty(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetAlavel()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(30410250, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetEbih()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28025341, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetGenryu()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(3435267, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetKukuri()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(13951694, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetOne()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(28834908, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            Assert.IsNull(result.Character.FreeCompanyId);
            Assert.IsEmpty(result.FreeCompanyMembers);
        }

        [Test]
        public async Task GetRhayn()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfile(18188832, fetchFreeCompanyMembers: true);
            Assert.IsNotNull(result);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
        }
    }
}