using xivapi_cs.ViewModels.CharacterProfile;

namespace xivapi_cs.Helper;

public static class ItemLevelHelper
{
    public static int CalculateAvgItemLevel(GearExtended gear)
    {
        var total = 0;

        total += GetItemLevel(gear.Body);
        total += GetItemLevel(gear.Bracelets);
        total += GetItemLevel(gear.Earrings);
        total += GetItemLevel(gear.Feet);
        total += GetItemLevel(gear.Hands);
        total += GetItemLevel(gear.Head);
        total += GetItemLevel(gear.Legs);
        var mainHand = GetItemLevel(gear.MainHand);
        total += GetItemLevel(gear.Necklace);
        var offHand = GetItemLevel(gear.OffHand);
        total += GetItemLevel(gear.Ring1);
        total += GetItemLevel(gear.Ring2);

        if (gear.OffHand == null)
        {
            // count MainHand twice if nothing equipped to OffHand
            total += mainHand * 2;
        }
        else
        {
            total += mainHand;
            total += offHand;
        }

        return (int)decimal.Divide(total, 12);
    }

    private static int GetItemLevel(GearPieceExtended? piece)
    {
        return piece?.Item.LevelItem ?? 0;
    }
}