using System;
using xivapi_cs.Enums;

namespace xivapi_cs.Extensions;

public static class DataCenterLogicalExtension
{
    public static DataCenterPhysical GetDataCenterPhysical(this DataCenterLogical dataCenterLogical)
    {
        switch (dataCenterLogical)
        {
            case DataCenterLogical.Chaos:
            case DataCenterLogical.Light:
                return DataCenterPhysical.Europe;
            case DataCenterLogical.Materia:
                return DataCenterPhysical.Oceania;
            case DataCenterLogical.Aether:
            case DataCenterLogical.Crystal:
            case DataCenterLogical.Primal:
                return DataCenterPhysical.NorthAmerica;
            case DataCenterLogical.Elemental:
            case DataCenterLogical.Gaia:
            case DataCenterLogical.Mana:
            case DataCenterLogical.Meteor:
                return DataCenterPhysical.Japan;
            default:
                throw new ArgumentOutOfRangeException(nameof(dataCenterLogical), dataCenterLogical, null);
        }
    }
}