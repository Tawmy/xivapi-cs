using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using xivapi_cs.Models.CharacterProfile;
using xivapi_cs.Models.CharacterSearch;
using xivapi_cs.Models.FreeCompanyProfile;
using xivapi_cs.Models.FreeCompanySearch;
using xivapi_cs.Models.LinkshellSearch;

namespace xivapi_cs
{
    public class XivApiClient
    {
        private readonly RestClient _client;

        public XivApiClient()
        {
            _client = new RestClient("https://xivapi.com/");
            _client.UseSystemTextJson();
        }

        #region Linkshell

        public async Task<LinkshellSearch> LinkshellSearch(string name, string server = null, int? page = null)
        {
            var req = new RestRequest("linkshell/search");
            req.AddParameter("name", name);
            if (server != null)
            {
                var servers = (await _client.ExecuteGetAsync<string[]>(new RestRequest("servers"))).Data;
                if (servers.Contains(server)) req.AddParameter("server", server);
                else return null;
            }

            if (page != null) req.AddParameter("page", page);

            var resp = await _client.ExecuteGetAsync(req);
            return JsonSerializer.Deserialize<LinkshellSearch>(resp.Content);
        }

        #endregion

        #region Free Company

        public async Task<FreeCompanySearch> FreeCompanySearch(string name, string server = null, int? page = null)
        {
            var req = new RestRequest("freecompany/search");
            req.AddParameter("name", name);
            if (server != null) req.AddParameter("server", server);
            if (page != null) req.AddParameter("page", page);

            var resp = await _client.ExecuteGetAsync<FreeCompanySearch>(req);
            return resp.Data;
        }

        public async Task<FreeCompanyProfile> FreeCompanyProfile(string id, bool fetchMembers = false)
        {
            var req = new RestRequest($"freecompany/{id}");

            var fetch = new List<string>();
            if (fetchMembers) fetch.Add("FCM");
            if (fetch.Count > 0) req.AddParameter("data", string.Join(",", fetch));

            var resp = await _client.ExecuteGetAsync(req);
            return JsonSerializer.Deserialize<FreeCompanyProfile>(resp.Content);
        }

        #endregion

        #region Character

        public async Task<CharacterSearch> CharacterSearch(string name, string server = null, int? page = null)
        {
            var req = new RestRequest("character/search");
            req.AddParameter("name", name);
            if (server != null) req.AddParameter("server", server);
            if (page != null) req.AddParameter("page", page);

            var resp = await _client.ExecuteGetAsync<CharacterSearch>(req);
            return resp.Data;
        }

        public async Task<CharacterProfile> CharacterProfile(int id,
            bool fetchAchievements = false,
            bool fetchFriends = false,
            bool fetchFreeCompany = false,
            bool fetchFreeCompanyMembers = false,
            bool fetchMinionsMounts = false)
        {
            var req = new RestRequest($"character/{id}");

            var fetch = new List<string>();
            if (fetchAchievements) fetch.Add("AC");
            if (fetchFriends) fetch.Add("FR");
            if (fetchFreeCompany) fetch.Add("FC");
            if (fetchFreeCompanyMembers) fetch.Add("FCM");
            if (fetchMinionsMounts) fetch.Add("MIMO");
            if (fetch.Count > 0) req.AddParameter("data", string.Join(",", fetch));

            var resp = await _client.ExecuteGetAsync(req);
            return JsonSerializer.Deserialize<CharacterProfile>(resp.Content);
        }

        public async Task<CharacterProfileExtended> CharacterProfileExtended(int id,
            bool fetchAchievements = false,
            bool fetchFriends = false,
            bool fetchFreeCompany = false,
            bool fetchFreeCompanyMembers = false,
            bool fetchMinionsMounts = false)
        {
            var req = new RestRequest($"character/{id}");

            var fetch = new List<string>();
            if (fetchAchievements) fetch.Add("AC");
            if (fetchFriends) fetch.Add("FR");
            if (fetchFreeCompany) fetch.Add("FC");
            if (fetchFreeCompanyMembers) fetch.Add("FCM");
            if (fetchMinionsMounts) fetch.Add("MIMO");
            if (fetch.Count > 0) req.AddParameter("data", string.Join(",", fetch));

            req.AddParameter("extended", 1);

            var resp = await _client.ExecuteGetAsync(req);
            return JsonSerializer.Deserialize<CharacterProfileExtended>(resp.Content);
        }

        #endregion
    }
}