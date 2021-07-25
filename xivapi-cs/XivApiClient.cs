using System.Text.Json;
using System.Text.Json.Serialization;
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

        public async Task<CharacterProfile> CharacterProfile(int id)
        {
            var req = new RestRequest($"character/{id}");
            var resp = await _client.ExecuteGetAsync<CharacterProfile>(req);
            return resp.Data;
        }
    }
}