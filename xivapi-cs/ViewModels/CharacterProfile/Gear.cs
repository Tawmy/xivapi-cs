namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class Gear
    {
        public Gear(DTOs.CharacterProfile.Gear dto)
        {
            Body = new GearPiece(dto.Body);
            Bracelets = new GearPiece(dto.Bracelets);
            Earrings = new GearPiece(dto.Earrings);
            Feet = new GearPiece(dto.Feet);
            Hands = new GearPiece(dto.Hands);
            Head = new GearPiece(dto.Head);
            Legs = new GearPiece(dto.Legs);
            MainHand = new GearPiece(dto.MainHand);
            Necklace = new GearPiece(dto.Necklace);

            if (dto.OffHand != null)
            {
                OffHand = new GearPiece(dto.OffHand);
            }
            
            Ring1 = new GearPiece(dto.Ring1);
            Ring2 = new GearPiece(dto.Ring2);

            if (dto.SoulCrystal != null)
            {
                SoulCrystal = new GearPiece(dto.SoulCrystal);
            }
        }

        public GearPiece Body { get; }
        public GearPiece Bracelets { get; }
        public GearPiece Earrings { get; }
        public GearPiece Feet { get; }
        public GearPiece Hands { get; }
        public GearPiece Head { get; }
        public GearPiece Legs { get; }
        public GearPiece MainHand { get; }
        public GearPiece Necklace { get; }
        public GearPiece? OffHand { get; }
        public GearPiece Ring1 { get; }
        public GearPiece Ring2 { get; }
        public GearPiece? SoulCrystal { get; }
    }
}