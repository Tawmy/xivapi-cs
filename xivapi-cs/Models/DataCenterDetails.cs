using System;
using xivapi_cs.Enums;
using xivapi_cs.Extensions;

namespace xivapi_cs.Models;

public class DataCenterDetails
{
    internal DataCenterDetails(string dataCenterLogical)
    {
        DataCenterLogical = (DataCenterLogical) Enum.Parse(typeof(DataCenterLogical), dataCenterLogical);
    }

    protected DataCenterDetails(DataCenterLogical dataCenterLogical)
    {
        DataCenterLogical = dataCenterLogical;
    }
    
    public DataCenterLogical DataCenterLogical { get; }
    public DataCenterPhysical DataCenterPhysical => DataCenterLogical.GetDataCenterPhysical();

    public override string ToString()
    {
        return DataCenterLogical.ToString();
    }
}