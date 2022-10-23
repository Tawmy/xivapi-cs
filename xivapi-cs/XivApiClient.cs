using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using xivapi_cs.ViewModels.CharacterProfile;

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

        private async Task<bool> IsValidServer(string server)
        {
            var servers = (await _client.ExecuteGetAsync<string[]>(new RestRequest("servers"))).Data;
            if (servers.Contains(server)) return true;
            throw new ArgumentException("Invalid server");
        }

        #region Linkshell

        public async Task<DTOs.LinkshellSearch.LinkshellSearch> LinkshellSearchRegular(string name, string server = null, int? page = null)
        {
            return await LinkshellSearch("linkshell/search", name, server, page);
        }

        public async Task<DTOs.LinkshellSearch.LinkshellSearch> LinkshellSearchCrossworld(string name, int? page = null)
        {
            return await LinkshellSearch("linkshell/crossworld/search", name, null, page);
        }

        private async Task<DTOs.LinkshellSearch.LinkshellSearch> LinkshellSearch(string reqStr, string name, string server, int? page)
        {
            var req = new RestRequest(reqStr);
            req.AddParameter("name", name);
            if (server != null)
                if (await IsValidServer(server))
                    req.AddParameter("server", server);

            if (page != null) req.AddParameter("page", page);

            var resp = await _client.ExecuteGetAsync(req);
            return JsonSerializer.Deserialize<DTOs.LinkshellSearch.LinkshellSearch>(resp.Content);
        }

        public async Task<DTOs.LinkshellProfile.Linkshell> LinkshellProfileRegular(string id, int? page = null)
        {
            return await LinkshellProfile($"linkshell/{id}", page);
        }

        public async Task<DTOs.LinkshellProfile.Linkshell> LinkshellProfileCrossworld(string id, int? page = null)
        {
            return await LinkshellProfile($"linkshell/crossworld/{id}", page);
        }

        private async Task<DTOs.LinkshellProfile.Linkshell> LinkshellProfile(string reqStr, int? page)
        {
            var req = new RestRequest(reqStr);
            if (page != null) req.AddParameter("page", page);

            var resp = await _client.ExecuteGetAsync(req);
            return JsonSerializer.Deserialize<DTOs.LinkshellProfile.Linkshell>(resp.Content);
        }

        #endregion

        #region Free Company

        public async Task<DTOs.FreeCompanySearch.FreeCompanySearch> FreeCompanySearch(string name, string server = null, int? page = null)
        {
            var req = new RestRequest("freecompany/search");
            req.AddParameter("name", name);
            if (server != null)
                if (await IsValidServer(server))
                    req.AddParameter("server", server);

            if (page != null) req.AddParameter("page", page);

            var resp = await _client.ExecuteGetAsync<DTOs.FreeCompanySearch.FreeCompanySearch>(req);
            return resp.Data;
        }

        public async Task<DTOs.FreeCompanyProfile.FreeCompanyProfile> FreeCompanyProfile(string id, bool fetchMembers = false)
        {
            var req = new RestRequest($"freecompany/{id}");

            var fetch = new List<string>();
            if (fetchMembers) fetch.Add("FCM");
            if (fetch.Count > 0) req.AddParameter("data", string.Join(",", fetch));

            var resp = await _client.ExecuteGetAsync(req);
            return JsonSerializer.Deserialize<DTOs.FreeCompanyProfile.FreeCompanyProfile>(resp.Content);
        }

        #endregion

        #region Character

        public async Task<DTOs.CharacterSearch.CharacterSearch> CharacterSearch(string name, string server = null, int? page = null)
        {
            var req = new RestRequest("character/search");
            req.AddParameter("name", name);
            if (server != null)
                if (await IsValidServer(server))
                    req.AddParameter("server", server);

            if (page != null) req.AddParameter("page", page);

            var resp = await _client.ExecuteGetAsync<DTOs.CharacterSearch.CharacterSearch>(req);
            return resp.Data;
        }

        public async Task<CharacterProfile?> CharacterProfile(int id,
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
            var des = JsonSerializer.Deserialize<DTOs.CharacterProfile.CharacterProfile>(resp.Content);
            return des != null ? new CharacterProfile(des) : null;
        }

        public async Task<CharacterProfileExtended?> CharacterProfileExtended(int id,
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
            var des = JsonSerializer.Deserialize<DTOs.CharacterProfile.CharacterProfileExtended>(resp.Content);
            return des != null ? new CharacterProfileExtended(des) : null;
        }

        #endregion
    }
}