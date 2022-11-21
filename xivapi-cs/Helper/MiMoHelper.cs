namespace xivapi_cs.Helper;

internal static class MiMoHelper
{
    public static decimal GetMinionPercentage(int minions)
    {
        var perc = decimal.Divide(minions, Values.MinionsTotal);
        return decimal.Multiply(perc, 100);
    }

    public static decimal GetMountPercentage(int mounts)
    {
        var perc = decimal.Divide(mounts, Values.MountsTotal);
        return decimal.Multiply(perc, 100);
    }
}