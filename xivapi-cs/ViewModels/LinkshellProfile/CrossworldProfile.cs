using xivapi_cs.Models;

namespace xivapi_cs.ViewModels.LinkshellProfile;

public class CrossworldProfile : ProfileBase
{
    internal CrossworldProfile(DTOs.LinkshellProfile.Profile dto) : base(dto)
    {
        DataCenterDetails = new DataCenterDetails(dto.Server);
    }
    
    public DataCenterDetails DataCenterDetails { get; }
}