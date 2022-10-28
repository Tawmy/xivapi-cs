using System;
using System.Linq;
using NUnit.Framework;
using xivapi_cs.Enums;
using xivapi_cs.Extensions;

namespace xivapi_cs.tests;

public class ExtensionTests
{
    [Test]
    public void TestJobExtension()
    {
        foreach (var job in (Job[]) Enum.GetValues(typeof(Job)))
        {
            var res = job.GetMateriaStats();
            Assert.Greater(res.Count(), 2);
        }
    }

    [Test]
    public void TestDataCenterLogicalExtension()
    {
        foreach (var dataCenterLogical in (DataCenterLogical[]) Enum.GetValues(typeof(DataCenterLogical)))
        {
            Assert.DoesNotThrow(() => dataCenterLogical.GetDataCenterPhysical());
        }
    }

    [Test]
    public void TestHomeWorldExtension()
    {
        foreach (var homeWorld in (HomeWorld[]) Enum.GetValues(typeof(HomeWorld)))
        {
            Assert.DoesNotThrow(() => homeWorld.GetDataCenterLogical());
        }
    }
}