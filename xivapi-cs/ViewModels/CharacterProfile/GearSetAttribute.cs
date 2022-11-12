using System.ComponentModel.DataAnnotations;
using xivapi_cs.Extensions;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class GearSetAttribute
{
    internal GearSetAttribute(DTOs.CharacterProfile.GearSetAttribute dto)
    {
        Attribute = (Enums.Attribute) dto.Attribute.Id;
        Value = dto.Value;
    }

    public Enums.Attribute Attribute { get; }
    public string Name => Attribute.GetAttribute<DisplayAttribute>()!.Name!;
    public int Value { get; }
}