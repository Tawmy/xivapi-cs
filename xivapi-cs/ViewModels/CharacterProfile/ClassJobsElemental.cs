namespace xivapi_cs.ViewModels.CharacterProfile;

public class ClassJobsElemental
{
    internal ClassJobsElemental(DTOs.CharacterProfile.ClassJobsElemental dto)
    {
        ExpLevel = dto.ExpLevel;
        ExpLevelMax = dto.ExpLevelMax;
        ExpLevelTogo = dto.ExpLevelTogo;
        Level = dto.Level;
        Name = dto.Name;
    }

    public int ExpLevel { get; }
    public int ExpLevelMax { get; }
    public int ExpLevelTogo { get; }
    public int Level { get; }
    public string Name { get; }
}