using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using xivapi_cs.Models;

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

        public async Task<CharacterSearch> CharacterSearch(string name, string server)
        {
            var req = new RestRequest($"character/search");
            req.AddParameter("name", name);
            req.AddParameter("server", server);
            var resp = await _client.ExecuteGetAsync<CharacterSearch>(req);
            return resp.Data;
        }
        
        public async Task<CharacterSearch> CharacterSearch(string firstName, string lastName, string server)
        {
            return await CharacterSearch($"{firstName} {lastName}", server);
        }

        public async Task<CharacterProfile> CharacterProfile(int id)
        {
            var req = new RestRequest($"character/{id}");
            var resp = await _client.ExecuteGetAsync<CharacterProfile>(req);
            return resp.Data;
        }
    }
}