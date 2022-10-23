namespace xivapi_cs.DTOs.CharacterProfile;

public class ClassJobBase
{
    public int ExpLevel { get; init; }
    public int ExpLevelMax { get; init; }
    public int ExpLevelTogo { get; init; }
    public bool IsSpecialised { get; init; }
    public int Level { get; init; }
    public string Name { get; init; }
    public UnlockedState UnlockedState { get; init; }
}