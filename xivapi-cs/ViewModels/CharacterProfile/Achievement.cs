namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class Achievement
    {
        public Achievement(DTOs.CharacterProfile.Achievement dto)
        {
            Date = dto.Date;
            Id = dto.Id;
        }

        public int Date { get; }   // TODO make this datetime?
        public int Id { get; }
    }
}