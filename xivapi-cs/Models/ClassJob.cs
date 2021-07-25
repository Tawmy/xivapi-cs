namespace xivapi_cs.Models
{
    public class ClassJob
    {
        public int ClassID { get; set; }
        public int ExpLevel { get; set; }
        public int ExpLevelMax { get; set; }
        public int ExpLevelTogo { get; set; }
        public bool IsSpecialised { get; set; }
        public int JobID { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public UnlockedState UnlockedState { get; set; }
    }
}