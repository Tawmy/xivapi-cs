namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class GearSetAttribute
    {
        public GearSetAttribute(DTOs.CharacterProfile.GearSetAttribute dto)
        {
            Attribute = new Attribute(dto.Attribute);
            Value = dto.Value;
        }

        public Attribute Attribute { get; }
        public int Value { get; }
    }
}