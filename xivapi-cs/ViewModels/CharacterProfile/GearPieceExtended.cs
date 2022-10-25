using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class GearPieceExtended : GearPieceBase
{
    internal GearPieceExtended(DTOs.CharacterProfile.GearPieceExtended dto) : base(dto)
    {
        if (dto.Dye != null)
        {
            Dye = new IconAttribute(dto.Dye);
        }

        Item = new Item(dto.Item);
        Materia = dto.Materia.Select(x => new IconUrlAttribute(x)).ToArray();

        if (dto.Mirage != null)
        {
            Mirage = new IconAttribute(dto.Mirage);
        }
    }

    public IconAttribute? Dye { get; }
    public Item Item { get; }
    public IconUrlAttribute[] Materia { get; }
    public IconAttribute? Mirage { get; }
}