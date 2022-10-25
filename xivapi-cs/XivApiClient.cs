using System;
using System.Collections.Generic;
using System.Linq;
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

    private async Task<bool> IsValidServer(string server)
    {
        var servers = (await _client.ExecuteGetAsync<string[]>(new RestRequest("servers"))).Data;
        if (servers.Contains(server))
        {
            return true;
        }

        throw new ArgumentException("Invalid server");
    }

    #region Free Company Profile

    public async Task<FreeCompanyProfile?> FreeCompanyProfile(string id, bool fetchMembers)
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

    public async Task<LinkshellSearch?> LinkshellSearchRegular(string name)
    {
        return await LinkshellSearchRegularInternal(name, null, null);
    }

    public async Task<LinkshellSearch?> LinkshellSearchRegular(string name, string server)
    {
        return await LinkshellSearchRegularInternal(name, server, null);
    }

    public async Task<LinkshellSearch?> LinkshellSearchRegular(string name, string server, int page)
    {
        return await LinkshellSearchRegularInternal(name, server, page);
    }

    public async Task<LinkshellSearch?> LinkshellSearchRegular(string name, int page)
    {
        return await LinkshellSearchRegularInternal(name, null, page);
    }

    public async Task<LinkshellSearch?> LinkshellSearchRegularInternal(string name, string? server, int? page)
    {
        var res = await LinkshellSearch("linkshell/search", name, server, page);
        return res != null ? new LinkshellSearch(res) : null;
    }

    public async Task<CrossworldLinkshellSearch?> LinkshellSearchCrossworld(string name)
    {
        return await LinkshellSearchCrossworldInternal(name, null);
    }

    public async Task<CrossworldLinkshellSearch?> LinkshellSearchCrossworld(string name, int page)
    {
        return await LinkshellSearchCrossworldInternal(name, null);
    }

    private async Task<CrossworldLinkshellSearch?> LinkshellSearchCrossworldInternal(string name, int? page)
    {
        var res = await LinkshellSearch("linkshell/crossworld/search", name, null, page);
        return res != null ? new CrossworldLinkshellSearch(res) : null;
    }

    private async Task<DTOs.LinkshellSearch.LinkshellSearch?> LinkshellSearch(string reqStr, string name,
        string? server, int? page)
    {
        var req = new RestRequest(reqStr);
        req.AddParameter("name", name);

        if (server != null)
        {
            if (await IsValidServer(server))
            {
                req.AddParameter("server", server);
            }
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

    public async Task<Linkshell?> LinkshellProfileRegular(string id)
    {
        return await LinkshellProfileRegularInternal(id, null);
    }

    public async Task<Linkshell?> LinkshellProfileRegular(string id, int page)
    {
        return await LinkshellProfileRegularInternal(id, page);
    }

    private async Task<Linkshell?> LinkshellProfileRegularInternal(string id, int? page)
    {
        var res = await LinkshellProfile($"linkshell/{id}", page);
        return res != null ? new Linkshell(res) : null;
    }

    public async Task<CrossworldLinkshell?> LinkshellProfileCrossworld(string id)
    {
        return await LinkshellProfileCrossworldInternal(id, null);
    }

    public async Task<CrossworldLinkshell?> LinkshellProfileCrossworld(string id, int page)
    {
        return await LinkshellProfileCrossworldInternal(id, page);
    }

    private async Task<CrossworldLinkshell?> LinkshellProfileCrossworldInternal(string id, int? page)
    {
        var res = await LinkshellProfile($"linkshell/crossworld/{id}", page);
        return res != null ? new CrossworldLinkshell(res) : null;
    }

    private async Task<DTOs.LinkshellProfile.Linkshell?> LinkshellProfile(string reqStr, int? page)
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

    public async Task<FreeCompanySearch?> FreeCompanySearch(string name)
    {
        return await FreeCompanySearchInternal(name, null, null);
    }

    public async Task<FreeCompanySearch?> FreeCompanySearch(string name, string server)
    {
        return await FreeCompanySearchInternal(name, server, null);
    }

    public async Task<FreeCompanySearch?> FreeCompanySearch(string name, string server, int page)
    {
        return await FreeCompanySearchInternal(name, server, page);
    }

    public async Task<FreeCompanySearch?> FreeCompanySearch(string name, int page)
    {
        return await FreeCompanySearchInternal(name, null, page);
    }

    private async Task<FreeCompanySearch?> FreeCompanySearchInternal(string name, string? server, int? page)
    {
        var req = new RestRequest("freecompany/search");
        req.AddParameter("name", name);
        if (server != null)
        {
            if (await IsValidServer(server))
            {
                req.AddParameter("server", server);
            }
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

    public async Task<CharacterSearch?> CharacterSearch(string name)
    {
        return await CharacterSearchInternal(name, null, null);
    }

    public async Task<CharacterSearch?> CharacterSearch(string name, string server)
    {
        return await CharacterSearchInternal(name, server, null);
    }

    public async Task<CharacterSearch?> CharacterSearch(string name, string server, int page)
    {
        return await CharacterSearchInternal(name, server, page);
    }

    public async Task<CharacterSearch?> CharacterSearch(string name, int page)
    {
        return await CharacterSearchInternal(name, null, page);
    }

    private async Task<CharacterSearch?> CharacterSearchInternal(string name, string? server, int? page)
    {
        var req = new RestRequest("character/search");
        req.AddParameter("name", name);
        if (server != null)
        {
            if (await IsValidServer(server))
            {
                req.AddParameter("server", server);
            }
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

    public async Task<CharacterProfile?> CharacterProfile(int id, CharacterProfileOptions options)
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

    public async Task<CharacterProfileExtended?> CharacterProfileExtended(int id, CharacterProfileOptions options)
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