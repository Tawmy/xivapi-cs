namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class Gear
    {
        public Gear(DTOs.CharacterProfile.Gear dto)
        {
            if (dto.Body != null)
            {
                Body = new GearPiece(dto.Body);
            }
            if (dto.Bracelets != null)
            {
                Bracelets = new GearPiece(dto.Bracelets);
            }
            if (dto.Earrings != null)
            {
                Earrings = new GearPiece(dto.Earrings);
            }
            if (dto.Feet != null)
            {
                Feet = new GearPiece(dto.Feet);
            }
            if (dto.Hands != null)
            {
                Hands = new GearPiece(dto.Hands);
            }
            if (dto.Head != null)
            {
                Head = new GearPiece(dto.Head);
            }
            if (dto.Legs != null)
            {
                Legs = new GearPiece(dto.Legs);
            }

            MainHand = new GearPiece(dto.MainHand);
            
            if (dto.Necklace != null)
            {
                Necklace = new GearPiece(dto.Necklace);
            }
            if (dto.OffHand != null)
            {
                OffHand = new GearPiece(dto.OffHand);
            }
            if (dto.Ring1 != null)
            {
                Ring1 = new GearPiece(dto.Ring1);
            }
            if (dto.Ring2 != null)
            {
                Ring2 = new GearPiece(dto.Ring2);
            }
            if (dto.SoulCrystal != null)
            {
                SoulCrystal = new GearPiece(dto.SoulCrystal);
            }
        }

        public GearPiece? Body { get; }
        public GearPiece? Bracelets { get; }
        public GearPiece? Earrings { get; }
        public GearPiece? Feet { get; }
        public GearPiece? Hands { get; }
        public GearPiece? Head { get; }
        public GearPiece? Legs { get; }
        public GearPiece MainHand { get; }
        public GearPiece? Necklace { get; }
        public GearPiece? OffHand { get; }
        public GearPiece? Ring1 { get; }
        public GearPiece? Ring2 { get; }
        public GearPiece? SoulCrystal { get; }
    }
}