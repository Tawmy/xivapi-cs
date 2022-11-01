using System.ComponentModel.DataAnnotations;

namespace xivapi_cs.Enums;

public enum GrandCompany
{
    [Display(Name="The Maelstrom")]
    Maelstrom,
    
    [Display(Name="The Immortal Flames")]
    ImmortalFlames,
    
    [Display(Name="The Order of the Twin Adder")]
    OrderTwinAdder
}