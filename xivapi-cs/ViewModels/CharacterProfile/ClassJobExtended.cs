namespace xivapi_cs.ViewModels.CharacterProfile;

public class ClassJobExtended : ClassJobBase
{
    public ClassJobExtended(DTOs.CharacterProfile.ClassJobExtended dto) : base(dto)
    {
        Class = new Class(dto.Class);
        Job = new Job(dto.Job);
    }

    public Class Class { get; }
    public Job Job { get; }
}