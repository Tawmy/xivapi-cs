namespace xivapi_cs.ViewModels.CharacterProfile;

public class Item : IconAttribute
{
    internal Item(DTOs.CharacterProfile.Item dto) : base(dto)
    {
        ClassJobCategory = new Attribute(dto.ClassJobCategory);

        if (dto.ItemUiCategory != null)
        {
            ItemUiCategory = new Attribute(dto.ItemUiCategory);
        }

        LevelEquip = dto.LevelEquip;
        LevelItem = dto.LevelItem;
        Rarity = dto.Rarity;
    }

    public Attribute ClassJobCategory { get; }
    public Attribute? ItemUiCategory { get; }
    public int LevelEquip { get; }
    public int LevelItem { get; }
    public int Rarity { get; }
}