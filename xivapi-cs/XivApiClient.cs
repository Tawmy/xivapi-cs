using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using xivapi_cs.Models.CharacterProfile;
using xivapi_cs.Models.CharacterSearch;

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
    }
}