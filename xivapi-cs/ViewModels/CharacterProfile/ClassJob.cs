namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class ClassJob : ClassJobBase
    {
        public ClassJob(DTOs.CharacterProfile.ClassJob dto) : base(dto)
        {
            ClassId = dto.ClassId;
            JobId = dto.JobId;
        }

        public int ClassId { get; }
        public int JobId { get; }
    }
}