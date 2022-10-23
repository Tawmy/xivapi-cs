using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class GearSetExtended
    {
        public GearSetExtended(DTOs.CharacterProfile.GearSetExtended dto)
        {
            Attributes = dto.Attributes.Select(x => new GearSetAttribute(x)).ToArray();
            Class = new Job(dto.Class);
            Gear = new GearExtended(dto.Gear);
        }

        public GearSetAttribute[] Attributes { get; }
        public Job Class { get; }   // Job type because no ClassJobCategory from API
        public GearExtended Gear { get; }
    }
}