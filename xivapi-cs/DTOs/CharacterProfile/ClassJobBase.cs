namespace xivapi_cs.DTOs.CharacterProfile
{
    public class ClassJobBase
    {
        public int ExpLevel { get; set; }
        public int ExpLevelMax { get; set; }
        public int ExpLevelTogo { get; set; }
        public bool IsSpecialised { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public UnlockedState UnlockedState { get; set; }
    }
}