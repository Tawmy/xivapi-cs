using xivapi_cs.Helper;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class GearExtended
{
    internal GearExtended(DTOs.CharacterProfile.GearExtended dto)
    {
        if (dto.Body != null)
        {
            Body = new GearPieceExtended(dto.Body);
        }

        if (dto.Bracelets != null)
        {
            Bracelets = new GearPieceExtended(dto.Bracelets);
        }

        if (dto.Earrings != null)
        {
            Earrings = new GearPieceExtended(dto.Earrings);
        }

        if (dto.Feet != null)
        {
            Feet = new GearPieceExtended(dto.Feet);
        }

        if (dto.Hands != null)
        {
            Hands = new GearPieceExtended(dto.Hands);
        }

        if (dto.Head != null)
        {
            Head = new GearPieceExtended(dto.Head);
        }

        if (dto.Legs != null)
        {
            Legs = new GearPieceExtended(dto.Legs);
        }

        MainHand = new GearPieceExtended(dto.MainHand);
        if (dto.Necklace != null)
        {
            Necklace = new GearPieceExtended(dto.Necklace);
        }

        if (dto.OffHand != null)
        {
            OffHand = new GearPieceExtended(dto.OffHand);
        }

        if (dto.Ring1 != null)
        {
            Ring1 = new GearPieceExtended(dto.Ring1);
        }

        if (dto.Ring2 != null)
        {
            Ring2 = new GearPieceExtended(dto.Ring2);
        }

        if (dto.SoulCrystal != null)
        {
            SoulCrystal = new GearPieceExtended(dto.SoulCrystal);
        }
    }

    public GearPieceExtended? Body { get; }
    public GearPieceExtended? Bracelets { get; }
    public GearPieceExtended? Earrings { get; }
    public GearPieceExtended? Feet { get; }
    public GearPieceExtended? Hands { get; }
    public GearPieceExtended? Head { get; }
    public GearPieceExtended? Legs { get; }
    public GearPieceExtended MainHand { get; }
    public GearPieceExtended? Necklace { get; }
    public GearPieceExtended? OffHand { get; }
    public GearPieceExtended? Ring1 { get; }
    public GearPieceExtended? Ring2 { get; }
    public GearPieceExtended? SoulCrystal { get; }
    public int AverageItemLevel => ItemLevelHelper.CalculateAvgItemLevel(this);
}