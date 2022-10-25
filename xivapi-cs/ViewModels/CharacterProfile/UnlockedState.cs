namespace xivapi_cs.ViewModels.CharacterProfile;

public class UnlockedState
{
    internal UnlockedState(DTOs.CharacterProfile.UnlockedState dto)
    {
        Id = dto.Id;
        Name = dto.Name;
    }

    public int? Id { get; }
    public string Name { get; }
}