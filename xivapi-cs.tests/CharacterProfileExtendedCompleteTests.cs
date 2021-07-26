using System.Threading.Tasks;
using NUnit.Framework;

namespace xivapi_cs.tests
{
    public class CharacterProfileExtendedCompleteTests
    {
        /*
         * Some of these are not passing due to the bug (?) explained in CharacterProfileFriendsTests
         */
        [Test]
        public async Task GetAlyx()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(28812634, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetLisa()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(32691240, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetHalvar()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(28915387, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetFuoca()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(21201379, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetHena()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(28835226, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            // Mounts not asserted as user does not have any
        }
        
        [Test]
        public async Task GetAlavel()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(30410250, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetEbih()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(28025341, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetGenryu()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(3435267, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetKukuri()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(13951694, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetOne()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(28834908, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
        
        [Test]
        public async Task GetRhayn()
        {
            var client = new XivApiClient();
            var result = await client.CharacterProfileExtended(18188832, true, true, true, true, true);
            Assert.IsNotNull(result);
            
            Assert.IsNotNull(result.AchievementsPublic);
            if (result.AchievementsPublic.Value)
            {
                Assert.IsNotNull(result.Achievements);
                Assert.IsNotEmpty(result.Achievements.List);
            }
            
            Assert.IsNotNull(result.FriendsPublic);
            if (result.FriendsPublic.Value)
            {
                Assert.IsNotNull(result.Friends);
                Assert.IsNotEmpty(result.Friends);
            }
            
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompany);
            if (!string.IsNullOrWhiteSpace(result.Character.FreeCompanyId)) Assert.IsNotNull(result.FreeCompanyMembers);
            
            Assert.IsNotNull(result.Minions);
            Assert.IsNotNull(result.Mounts);
        }
    }
}