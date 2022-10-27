using System.ComponentModel.DataAnnotations;

namespace xivapi_cs.Enums;

public enum Job
{
    [Display(Name = "Paladin")] Pld,

    [Display(Name = "Warrior")] War,

    [Display(Name = "Dark Knight")] Drk,

    [Display(Name = "Gunbreaker")] Gnb,

    [Display(Name = "White Mage")] Whm,

    [Display(Name = "Scholar")] Sch,

    [Display(Name = "Astrologian")] Ast,

    [Display(Name = "Sage")] Sge,

    [Display(Name = "Monk")] Mnk,

    [Display(Name = "Dragoon")] Drg,

    [Display(Name = "Ninja")] Nin,

    [Display(Name = "Samurai")] Sam,

    [Display(Name = "Reaper")] Rpr,

    [Display(Name = "Bard")] Brd,

    [Display(Name = "Machinist")] Mch,

    [Display(Name = "Dancer")] Dnc,

    [Display(Name = "Black Mage")] Blm,

    [Display(Name = "Summoner")] Smn,

    [Display(Name = "Red Mage")] Rdm,

    [Display(Name = "Blue Mage")] Blu,

    [Display(Name = "Carpenter")] Crp,

    [Display(Name = "Blacksmith")] Bsm,

    [Display(Name = "Armorer")] Arm,

    [Display(Name = "Goldsmith")] Gsm,

    [Display(Name = "Leatherworker")] Ltw,

    [Display(Name = "Weaver")] Wvr,

    [Display(Name = "Alchemist")] Alc,

    [Display(Name = "Culinarian")] Cln,

    [Display(Name = "Miner")] Mnr,

    [Display(Name = "Botanist")] Btn,

    [Display(Name = "Fisher")] Fsh
}