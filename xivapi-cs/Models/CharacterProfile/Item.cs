namespace xivapi_cs.Models.CharacterProfile
{
    public class Item
    {
        public ClassJobCategory ClassJobCategory { get; set; }
        public int ID { get; set; }
        public string Icon { get; set; }
        public ItemUICategory ItemUiCategory { get; set; }
        public int LevelEquip { get; set; }
        public int LevelItem { get; set; }
        public string Name { get; set; }
        public int Rarity { get; set; }
    }
}