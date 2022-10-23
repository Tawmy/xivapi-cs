using System;
using xivapi_cs.Enums;
using xivapi_cs.Extensions;

namespace xivapi_cs.Models;

public class HomeWorldDetails : DataCenterDetails
{
    internal HomeWorldDetails(string server) : this((HomeWorld) Enum.Parse(typeof(HomeWorld), server))
    {
    }

    private HomeWorldDetails(HomeWorld homeWorld) : base(homeWorld.GetDataCenterLogical())
    {
        HomeWorld = homeWorld;
    }

    public HomeWorld HomeWorld { get; }


    public override string ToString()
    {
        return HomeWorld.ToString();
    }
}