namespace xivapi_cs.ViewModels.CharacterProfile;

public class Reputation
{
    internal Reputation(DTOs.CharacterProfile.Reputation dto)
    {
        Name = dto.Name;
        Progress = dto.Progress;
        Rank = dto.Rank;
    }

    public string Name { get; }
    public int Progress { get; }
    public string Rank { get; }
}