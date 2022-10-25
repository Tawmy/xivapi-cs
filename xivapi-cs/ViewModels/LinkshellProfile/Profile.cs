using System.Collections.Generic;
using System.Linq;
using xivapi_cs.Models;

namespace xivapi_cs.ViewModels.LinkshellProfile;

public class Profile : ProfileBase
{
    internal Profile(DTOs.LinkshellProfile.Profile dto, IEnumerable<DTOs.CharacterShort> members) : base(dto)
    {
        HomeWorldDetails = new HomeWorldDetails(members.First().Server);
    }

    public HomeWorldDetails HomeWorldDetails { get; }
}