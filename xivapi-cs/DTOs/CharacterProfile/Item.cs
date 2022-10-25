namespace xivapi_cs.DTOs.CharacterProfile;

internal class Item : IconAttribute
{
    public Attribute ClassJobCategory { get; init; } = null!;
    public Attribute? ItemUiCategory { get; init; }
    public int LevelEquip { get; init; }
    public int LevelItem { get; init; }
    public int Rarity { get; init; }
}