using System.Text.Json.Serialization;

namespace xivapi_cs.DTOs.CharacterProfile
{
    public class Item : IconAttribute
    {
        public Attribute ClassJobCategory { get; init; }
        public Attribute? ItemUiCategory { get; init; }
        public int LevelEquip { get; init; }
        public int LevelItem { get; init; }
        public int Rarity { get; init; }
    }
}