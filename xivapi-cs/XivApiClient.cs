using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using xivapi_cs.Enums;
using xivapi_cs.ViewModels.CharacterProfile;
using xivapi_cs.ViewModels.CharacterSearch;
using xivapi_cs.ViewModels.FreeCompanyProfile;
using xivapi_cs.ViewModels.FreeCompanySearch;
using xivapi_cs.ViewModels.LinkshellProfile;
using xivapi_cs.ViewModels.LinkshellSearch;

namespace xivapi_cs;

public class XivApiClient
{
    private readonly RestClient _client;

    public XivApiClient()
    {
        _client = new RestClient("https://xivapi.com/");
        _client.UseSystemTextJson();
    }

    #region Free Company Profile

    public async Task<FreeCompanyProfile?> GetFreeCompanyProfileAsync(string id, bool fetchMembers)
    {
        var req = new RestRequest($"freecompany/{id}");

        var fetch = new List<string>();
        if (fetchMembers)
        {
            fetch.Add("FCM");
        }

        if (fetch.Count > 0)
        {
            req.AddParameter("data", string.Join(",", fetch));
        }

        var resp = await _client.ExecuteGetAsync(req);
        var des = JsonSerializer.Deserialize<DTOs.FreeCompanyProfile.FreeCompanyProfile>(resp.Content);
        return des != null ? new FreeCompanyProfile(des) : null;
    }

    #endregion

    #region Linkshell Search

    public async Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name)
    {
        return await SearchLinkshellRegularInternalAsync(name, null, null);
    }

    public async Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name, HomeWorld homeWorld)
    {
        return await SearchLinkshellRegularInternalAsync(name, homeWorld, null);
    }

    public async Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name, HomeWorld homeWorld, int page)
    {
        return await SearchLinkshellRegularInternalAsync(name, homeWorld, page);
    }

    public async Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name, int page)
    {
        return await SearchLinkshellRegularInternalAsync(name, null, page);
    }

    private async Task<LinkshellSearch?> SearchLinkshellRegularInternalAsync(string name, HomeWorld? homeWorld, int? page)
    {
        var res = await SearchLinkshellAsync("linkshell/search", name, homeWorld, page);
        return res != null ? new LinkshellSearch(res) : null;
    }

    public async Task<CrossworldLinkshellSearch?> SearchLinkshellCrossworldAsync(string name)
    {
        return await SearchLinkshellCrossworldInternalAsync(name, null);
    }

    public async Task<CrossworldLinkshellSearch?> SearchLinkshellCrossworldAsync(string name, int page)
    {
        return await SearchLinkshellCrossworldInternalAsync(name, null);
    }

    private async Task<CrossworldLinkshellSearch?> SearchLinkshellCrossworldInternalAsync(string name, int? page)
    {
        var res = await SearchLinkshellAsync("linkshell/crossworld/search", name, null, page);
        return res != null ? new CrossworldLinkshellSearch(res) : null;
    }

    private async Task<DTOs.LinkshellSearch.LinkshellSearch?> SearchLinkshellAsync(string reqStr, string name,
        HomeWorld? homeWorld, int? page)
    {
        var req = new RestRequest(reqStr);
        req.AddParameter("name", name);

        if (homeWorld != null)
        {
            req.AddParameter("server", homeWorld);
        }

        if (page != null)
        {
            req.AddParameter("page", page);
        }

        var resp = await _client.ExecuteGetAsync(req);
        return JsonSerializer.Deserialize<DTOs.LinkshellSearch.LinkshellSearch>(resp.Content);
    }

    #endregion

    #region Linkshell Profile

    public async Task<Linkshell?> GetLinkshellProfileRegularAsync(string id)
    {
        return await GetLinkshellProfileRegularInternalAsync(id, null);
    }

    public async Task<Linkshell?> GetLinkshellProfileRegularAsync(string id, int page)
    {
        return await GetLinkshellProfileRegularInternalAsync(id, page);
    }

    private async Task<Linkshell?> GetLinkshellProfileRegularInternalAsync(string id, int? page)
    {
        var res = await GetLinkshellProfileAsync($"linkshell/{id}", page);
        return res != null ? new Linkshell(res) : null;
    }

    public async Task<CrossworldLinkshell?> GetLinkshellProfileCrossworldAsync(string id)
    {
        return await GetLinkshellProfileCrossworldInternalAsync(id, null);
    }

    public async Task<CrossworldLinkshell?> GetLinkshellProfileCrossworldAsync(string id, int page)
    {
        return await GetLinkshellProfileCrossworldInternalAsync(id, page);
    }

    private async Task<CrossworldLinkshell?> GetLinkshellProfileCrossworldInternalAsync(string id, int? page)
    {
        var res = await GetLinkshellProfileAsync($"linkshell/crossworld/{id}", page);
        return res != null ? new CrossworldLinkshell(res) : null;
    }

    private async Task<DTOs.LinkshellProfile.Linkshell?> GetLinkshellProfileAsync(string reqStr, int? page)
    {
        var req = new RestRequest(reqStr);
        if (page != null)
        {
            req.AddParameter("page", page);
        }

        var resp = await _client.ExecuteGetAsync(req);
        return JsonSerializer.Deserialize<DTOs.LinkshellProfile.Linkshell>(resp.Content);
    }

    #endregion

    #region Free Company Search

    public async Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name)
    {
        return await SearchFreeCompanyInternalAsync(name, null, null);
    }

    public async Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name, HomeWorld homeWorld)
    {
        return await SearchFreeCompanyInternalAsync(name, homeWorld, null);
    }

    public async Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name, HomeWorld homeWorld, int page)
    {
        return await SearchFreeCompanyInternalAsync(name, homeWorld, page);
    }

    public async Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name, int page)
    {
        return await SearchFreeCompanyInternalAsync(name, null, page);
    }

    private async Task<FreeCompanySearch?> SearchFreeCompanyInternalAsync(string name, HomeWorld? homeWorld, int? page)
    {
        var req = new RestRequest("freecompany/search");
        req.AddParameter("name", name);
        if (homeWorld != null)
        {
            req.AddParameter("server", homeWorld);
        }

        if (page != null)
        {
            req.AddParameter("page", page);
        }

        var resp = await _client.ExecuteGetAsync(req);
        var des = JsonSerializer.Deserialize<DTOs.FreeCompanySearch.FreeCompanySearch>(resp.Content);
        return des != null ? new FreeCompanySearch(des) : null;
    }

    #endregion

    #region Character Search

    public async Task<CharacterSearch?> SearchCharacterAsync(string name)
    {
        return await SearchCharacterInternalAsync(name, null, null);
    }

    public async Task<CharacterSearch?> SearchCharacterAsync(string name, HomeWorld homeWorld)
    {
        return await SearchCharacterInternalAsync(name, homeWorld, null);
    }

    public async Task<CharacterSearch?> SearchCharacterAsync(string name, HomeWorld homeWorld, int page)
    {
        return await SearchCharacterInternalAsync(name, homeWorld, page);
    }

    public async Task<CharacterSearch?> SearchCharacterAsync(string name, int page)
    {
        return await SearchCharacterInternalAsync(name, null, page);
    }

    private async Task<CharacterSearch?> SearchCharacterInternalAsync(string name, HomeWorld? homeWorld, int? page)
    {
        var req = new RestRequest("character/search");
        req.AddParameter("name", name);

        if (homeWorld != null)
        {
            req.AddParameter("server", homeWorld);
        }

        if (page != null)
        {
            req.AddParameter("page", page);
        }

        var resp = await _client.ExecuteGetAsync(req);
        var des = JsonSerializer.Deserialize<DTOs.CharacterSearch.CharacterSearch>(resp.Content);
        return des != null ? new CharacterSearch(des) : null;
    }

    #endregion

    #region Character Profile

    public async Task<CharacterProfile?> GetCharacterProfileAsync(int id, CharacterProfileOptions options)
    {
        var req = new RestRequest($"character/{id}");

        var fetch = new List<string>();

        if (options.HasFlag(CharacterProfileOptions.Achievements))
        {
            fetch.Add("AC");
        }

        if (options.HasFlag(CharacterProfileOptions.Friends))
        {
            fetch.Add("FR");
        }

        if (options.HasFlag(CharacterProfileOptions.FreeCompany))
        {
            fetch.Add("FC");
        }

        if (options.HasFlag(CharacterProfileOptions.FreeCompanyMembers))
        {
            fetch.Add("FCM");
        }

        if (options.HasFlag(CharacterProfileOptions.MinionsMounts))
        {
            fetch.Add("MIMO");
        }

        if (fetch.Count > 0)
        {
            req.AddParameter("data", string.Join(",", fetch));
        }

        var resp = await _client.ExecuteGetAsync(req);
        var des = JsonSerializer.Deserialize<DTOs.CharacterProfile.CharacterProfile>(resp.Content);
        return des != null ? new CharacterProfile(des) : null;
    }

    public async Task<CharacterProfileExtended?> GetCharacterProfileExtendedAsync(int id, CharacterProfileOptions options)
    {
        var req = new RestRequest($"character/{id}");

        var fetch = new List<string>();

        if (options.HasFlag(CharacterProfileOptions.Achievements))
        {
            fetch.Add("AC");
        }

        if (options.HasFlag(CharacterProfileOptions.Friends))
        {
            fetch.Add("FR");
        }

        if (options.HasFlag(CharacterProfileOptions.FreeCompany))
        {
            fetch.Add("FC");
        }

        if (options.HasFlag(CharacterProfileOptions.FreeCompanyMembers))
        {
            fetch.Add("FCM");
        }

        if (options.HasFlag(CharacterProfileOptions.MinionsMounts))
        {
            fetch.Add("MIMO");
        }

        if (fetch.Count > 0)
        {
            req.AddParameter("data", string.Join(",", fetch));
        }

        req.AddParameter("extended", 1);

        var resp = await _client.ExecuteGetAsync(req);
        var des = JsonSerializer.Deserialize<DTOs.CharacterProfile.CharacterProfileExtended>(resp.Content);
        return des != null ? new CharacterProfileExtended(des) : null;
    }

    #endregion
}