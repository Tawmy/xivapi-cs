using System.Collections.Generic;

namespace xivapi_cs.Models
{
    public class GearSet
    {
        //public Attributes Attributes { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
        public int ClassID { get; set; }
        public Gear Gear { get; set; }
    }
}