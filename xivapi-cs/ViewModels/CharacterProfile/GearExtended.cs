namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class GearExtended
    {
        public GearExtended(DTOs.CharacterProfile.GearExtended dto)
        {
            Body = new GearPieceExtended(dto.Body);
            Bracelets = new GearPieceExtended(dto.Bracelets);
            Earrings = new GearPieceExtended(dto.Earrings);
            Feet = new GearPieceExtended(dto.Feet);
            Hands = new GearPieceExtended(dto.Hands);
            Head = new GearPieceExtended(dto.Head);
            Legs = new GearPieceExtended(dto.Legs);
            MainHand = new GearPieceExtended(dto.MainHand);
            Necklace = new GearPieceExtended(dto.Necklace);

            if (dto.OffHand != null)
            {
                OffHand = new GearPieceExtended(dto.OffHand);
            }
            
            Ring1 = new GearPieceExtended(dto.Ring1);
            Ring2 = new GearPieceExtended(dto.Ring2);

            if (dto.SoulCrystal != null)
            {
                SoulCrystal = new GearPieceExtended(dto.SoulCrystal);
            }
        }

        public GearPieceExtended Body { get; }
        public GearPieceExtended Bracelets { get; }
        public GearPieceExtended Earrings { get; }
        public GearPieceExtended Feet { get; }
        public GearPieceExtended Hands { get; }
        public GearPieceExtended Head { get; }
        public GearPieceExtended Legs { get; }
        public GearPieceExtended MainHand { get; }
        public GearPieceExtended Necklace { get; }
        public GearPieceExtended? OffHand { get; }
        public GearPieceExtended Ring1 { get; }
        public GearPieceExtended Ring2 { get; }
        public GearPieceExtended? SoulCrystal { get; }
    }
}