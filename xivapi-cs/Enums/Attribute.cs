using System.ComponentModel.DataAnnotations;

namespace xivapi_cs.Enums;

public enum Attribute
{
    [Display(Name = "Strength", ShortName = "STR")]
    Strength = 1,

    [Display(Name = "Dexterity", ShortName = "DEX")]
    Dexterity = 2,

    [Display(Name = "Vitality", ShortName = "VIT")]
    Vitality = 3,

    [Display(Name = "Intelligence", ShortName = "INT")]
    Intelligence = 4,

    [Display(Name = "Mind", ShortName = "MND")]
    Mind = 5,

    [Display(Name = "Piety", ShortName = "PIE")]
    Piety = 6,

    [Display(Name = "HP", Description = "Health Points")]
    Hp = 7,

    [Display(Name = "MP", Description = "Magic Points")]
    Mp = 8,

    [Display(Name = "GP", Description = "Gathering Points")]
    Gp = 10,

    [Display(Name = "CP", Description = "Crafting Points")]
    Cp = 11,

    [Display(Name = "Tenacity", ShortName = "TEN")]
    Tenacity = 19,

    [Display(Name = "Attack Power")] AttackPower = 20,

    [Display(Name = "Defense", ShortName = "DEF")]
    Defense = 21,

    [Display(Name = "Direct Hit Rate", ShortName = "DH")]
    DirectHitRate = 22,

    [Display(Name = "Magic Defense")] MagicDefense = 24,

    [Display(Name = "Critical Hit", ShortName = "Crit")]
    CriticalHit = 27,

    [Display(Name = "Attack Magic Potency")]
    AttackMagicPotency = 33,

    [Display(Name = "Healing Magic Potency")]
    HealingMagicPotency = 34,

    [Display(Name = "Determination", ShortName = "DET")]
    Determination = 44,

    [Display(Name = "Skill Speed", ShortName = "SkS")]
    SkillSpeed = 45,

    [Display(Name = "Spell Speed", ShortName = "SpS")]
    SpellSpeed = 46,

    [Display(Name = "Craftmanship")] Craftmanship = 70,

    [Display(Name = "Control")] Control = 71,

    [Display(Name = "Gathering")] Gathering = 72,

    [Display(Name = "Perception")] Perception = 73
}