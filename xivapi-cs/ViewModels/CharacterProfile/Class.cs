namespace xivapi_cs.ViewModels.CharacterProfile;

public class Class : Job
{
    public Class(DTOs.CharacterProfile.Class dto) : base(dto)
    {
        ClassJobCategory = new Attribute(dto.ClassJobCategory);
    }

    public Attribute ClassJobCategory { get; }
}