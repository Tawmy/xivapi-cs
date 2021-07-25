using System.Collections.Generic;

namespace xivapi_cs.Models
{
    public class GearSet
    {
        public Dictionary<string, int> Attributes { get; set; }
        public int ClassID { get; set; }
        public Gear Gear { get; set; }
    }
}