namespace xivapi_cs.ViewModels.CharacterProfile;

public class Job : IconUrlAttribute
{
    public Job(DTOs.CharacterProfile.Job dto) : base(dto)
    {
        Abbreviation = dto.Abbreviation;
    }

    public string Abbreviation { get; }
}