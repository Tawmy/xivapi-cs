namespace xivapi_cs.ViewModels.CharacterProfile;

public class Seeking
{
    public Seeking(DTOs.CharacterProfile.Seeking dto)
    {
        Icon = dto.Icon;
        Name = dto.Name;
        Status = dto.Status;
    }

    public string Icon { get; }
    public string Name { get; }
    public bool Status { get; }
}