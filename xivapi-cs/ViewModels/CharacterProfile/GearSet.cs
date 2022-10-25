using System.Collections.Generic;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class GearSet
{
    internal GearSet(DTOs.CharacterProfile.GearSet dto)
    {
        Attributes = dto.Attributes;
        ClassId = dto.ClassId;
        Gear = new Gear(dto.Gear);
    }

    public Dictionary<string, int> Attributes { get; }
    public int ClassId { get; }
    public Gear Gear { get; }
}