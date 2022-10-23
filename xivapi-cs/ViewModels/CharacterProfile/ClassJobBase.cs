namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class ClassJobBase
    {
        public ClassJobBase(DTOs.CharacterProfile.ClassJobBase dto)
        {
            ExpLevel = dto.ExpLevel;
            ExpLevelMax = dto.ExpLevelMax;
            ExpLevelTogo = dto.ExpLevelTogo;
            IsSpecialised = dto.IsSpecialised;
            Level = dto.Level;
            Name = dto.Name;
            UnlockedState = new UnlockedState(dto.UnlockedState);
        }

        public int ExpLevel { get; }
        public int ExpLevelMax { get; }
        public int ExpLevelTogo { get; }
        public bool IsSpecialised { get; }
        public int Level { get; }
        public string Name { get; }
        public UnlockedState UnlockedState { get; }
    }
}