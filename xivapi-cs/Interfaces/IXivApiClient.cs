using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using xivapi_cs.Enums;
using xivapi_cs.ViewModels.CharacterProfile;
using xivapi_cs.ViewModels.CharacterSearch;
using xivapi_cs.ViewModels.FreeCompanyProfile;
using xivapi_cs.ViewModels.FreeCompanySearch;
using xivapi_cs.ViewModels.LinkshellProfile;
using xivapi_cs.ViewModels.LinkshellSearch;

namespace xivapi_cs.Interfaces;

[SuppressMessage("ReSharper", "InvalidXmlDocComment")] // inheritdoc resharper bug
public interface IXivApiClient
{
    /// <summary>
    ///     Get a Free Company Profile by Lodestone ID.
    /// </summary>
    /// <param name="id">Free Company Lodestone ID.</param>
    /// <param name="fetchMembers">Whether to fetch all members of the FC. Takes more time.</param>
    /// <returns>ViewModel for Free Company Profile.</returns>
    Task<FreeCompanyProfile?> GetFreeCompanyProfileAsync(string id, bool fetchMembers);

    /// <summary>
    ///     Search for a Linkshell.
    /// </summary>
    /// <param name="name">Name of the Linkshell.</param>
    /// <returns>Search result for Linkshell search.</returns>
    Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name);

    /// <inheritdoc cref="SearchLinkshellRegularAsync(string)" />
    /// <param name="homeWorld">Home World of Linkshell.</param>
    Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name, HomeWorld homeWorld);

    /// <inheritdoc cref="SearchLinkshellRegularAsync(string, HomeWorld)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name, HomeWorld homeWorld, int page);

    /// <inheritdoc cref="SearchLinkshellRegularAsync(string)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<LinkshellSearch?> SearchLinkshellRegularAsync(string name, int page);

    /// <summary>
    ///     Search for a Cross-world Linkshell.
    /// </summary>
    /// <param name="name">Name of the Cross-world Linkshell.</param>
    /// <returns></returns>
    Task<CrossworldLinkshellSearch?> SearchLinkshellCrossworldAsync(string name);

    /// <inheritdoc cref="SearchLinkshellCrossworldAsync(string)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<CrossworldLinkshellSearch?> SearchLinkshellCrossworldAsync(string name, int page);

    /// <summary>
    ///     Get a Linkshell Profile by Lodestone ID.
    /// </summary>
    /// <param name="id">Linkshell Lodestone ID.</param>
    /// <returns>ViewModel for Linkshell.</returns>
    Task<Linkshell?> GetLinkshellProfileRegularAsync(string id);

    /// <inheritdoc cref="GetLinkshellProfileRegularAsync(string)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<Linkshell?> GetLinkshellProfileRegularAsync(string id, int page);

    /// <summary>
    ///     Get a Cross-world Linkshell Profile by Lodestone ID.
    /// </summary>
    /// <param name="id">Cross-world Linkshell Lodestone ID.</param>
    /// <returns>ViewModel for Cross-world Linkshell.</returns>
    Task<CrossworldLinkshell?> GetLinkshellProfileCrossworldAsync(string id);

    /// <inheritdoc cref="GetLinkshellProfileCrossworldAsync(string)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<CrossworldLinkshell?> GetLinkshellProfileCrossworldAsync(string id, int page);

    /// <summary>
    ///     Search for a Free Company.
    /// </summary>
    /// <param name="name">Name of the Free Company.</param>
    /// <returns>Search result for Free Company search.</returns>
    Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name);

    /// <inheritdoc cref="SearchFreeCompanyAsync(string)" />
    /// <param name="homeWorld">Home World of Free Company.</param>
    Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name, HomeWorld homeWorld);

    /// <inheritdoc cref="SearchFreeCompanyAsync(string, HomeWorld)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name, HomeWorld homeWorld, int page);

    /// <inheritdoc cref="SearchFreeCompanyAsync(string)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<FreeCompanySearch?> SearchFreeCompanyAsync(string name, int page);

    /// <summary>
    ///     Search for a Character.
    /// </summary>
    /// <param name="name">Name of the Character.</param>
    /// <returns>Search result for Character search.</returns>
    Task<CharacterSearch?> SearchCharacterAsync(string name);

    /// <inheritdoc cref="SearchCharacterAsync(string)" />
    /// <param name="homeWorld">Character's Home World.</param>
    Task<CharacterSearch?> SearchCharacterAsync(string name, HomeWorld homeWorld);

    /// <inheritdoc cref="SearchCharacterAsync(string, HomeWorld)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<CharacterSearch?> SearchCharacterAsync(string name, HomeWorld homeWorld, int page);

    /// <inheritdoc cref="SearchCharacterAsync(string)" />
    /// <param name="page">Which page to show. Lodestone always returns 50 results, which makes this necessary.</param>
    Task<CharacterSearch?> SearchCharacterAsync(string name, int page);

    /// <summary>
    ///     Get a Character Profile by Lodestone ID.
    /// </summary>
    /// <param name="id">Character Lodestone ID.</param>
    /// <param name="options">Flags enum for additional data. Each makes the request take longer.</param>
    /// <returns>ViewModel for Character Profile.</returns>
    Task<CharacterProfile?> GetCharacterProfileAsync(int id, CharacterProfileOptions options);

    /// <summary>
    ///     Get an Extended Character Profile by Lodestone ID.
    /// </summary>
    /// <remarks>
    ///     This shows more information than the regular character profile, but takes notably longer.
    /// </remarks>
    /// <param name="id">Character Lodestone ID.</param>
    /// <param name="options">Flags enum for additional data. Each makes the request take longer.</param>
    /// <returns>ViewModel for Extended Character Profile.</returns>
    Task<CharacterProfileExtended?> GetCharacterProfileExtendedAsync(int id,
        CharacterProfileOptions options);
}