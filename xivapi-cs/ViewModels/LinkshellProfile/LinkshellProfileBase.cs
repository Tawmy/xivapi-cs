using System.Linq;

namespace xivapi_cs.ViewModels.LinkshellProfile;

public class LinkshellProfileBase
{
    internal LinkshellProfileBase(DTOs.LinkshellProfile.LinkshellProfile dto)
    {
        Id = dto.Id;
        Pagination = new Pagination(dto.Pagination);
        Results = dto.Results.Select(x => new CharacterShort(x)).ToArray();
    }
    
    public string Id { get; }
    public Pagination Pagination { get; }
    public CharacterShort[] Results { get; }
}