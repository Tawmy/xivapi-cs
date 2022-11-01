using System.ComponentModel.DataAnnotations;

namespace xivapi_cs.Enums;

public enum GrandCompany
{
    [Display(Name = "The Maelstrom")] Maelstrom = 1,

    [Display(Name = "The Order of the Twin Adder")]
    OrderTwinAdder = 2,

    [Display(Name = "The Immortal Flames")]
    ImmortalFlames = 3
}