namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class Attribute
    {
        public Attribute(DTOs.CharacterProfile.Attribute dto)
        {
            Id = dto.Id;
            Name = dto.Name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}