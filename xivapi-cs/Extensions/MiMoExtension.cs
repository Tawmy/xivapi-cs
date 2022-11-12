using xivapi_cs.ViewModels.CharacterProfile;

namespace xivapi_cs.Extensions;

public static class MiMoExtension
{
    public static decimal GetMinionPercentage(this Pet[] minions)
    {
        var perc = decimal.Divide(minions.Length, Values.MinionsTotal);
        return decimal.Multiply(perc, 100);
    }

    public static decimal GetMountPercentage(this Pet[] mounts)
    {
        var perc = decimal.Divide(mounts.Length, Values.MountsTotal);
        return decimal.Multiply(perc, 100);
    }
}