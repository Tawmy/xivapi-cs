using System;
using xivapi_cs.Enums;

namespace xivapi_cs.Extensions;

public static class HomeWorldExtension
{
    public static DataCenterLogical GetDataCenterLogical(this HomeWorld homeWorld)
    {
        switch (homeWorld)
        {
            case HomeWorld.Cerberus:
            case HomeWorld.Louisoix:
            case HomeWorld.Moogle:
            case HomeWorld.Omega:
            case HomeWorld.Phantom:
            case HomeWorld.Ragnarok:
            case HomeWorld.Sagittarius:
            case HomeWorld.Spriggan:
                return DataCenterLogical.Chaos;
            case HomeWorld.Alpha:
            case HomeWorld.Lich:
            case HomeWorld.Odin:
            case HomeWorld.Phoenix:
            case HomeWorld.Raiden:
            case HomeWorld.Shiva:
            case HomeWorld.Twintania:
            case HomeWorld.Zodiark:
                return DataCenterLogical.Light;
            case HomeWorld.Bismarck:
            case HomeWorld.Ravana:
            case HomeWorld.Sephirot:
            case HomeWorld.Sophia:
            case HomeWorld.Zurvan:
                return DataCenterLogical.Materia;
            case HomeWorld.Adamantoise:
            case HomeWorld.Cactuar:
            case HomeWorld.Faerie:
            case HomeWorld.Gilgamesh:
            case HomeWorld.Jenova:
            case HomeWorld.Midgardsormr:
            case HomeWorld.Sargatanas:
            case HomeWorld.Siren:
                return DataCenterLogical.Aether;
            case HomeWorld.Balmung:
            case HomeWorld.Brynhildr:
            case HomeWorld.Coeurl:
            case HomeWorld.Diabolos:
            case HomeWorld.Goblin:
            case HomeWorld.Malboro:
            case HomeWorld.Mateus:
            case HomeWorld.Zalera:
                return DataCenterLogical.Crystal;
            case HomeWorld.Behemoth:
            case HomeWorld.Excalibur:
            case HomeWorld.Exodus:
            case HomeWorld.Famfrit:
            case HomeWorld.Hyperion:
            case HomeWorld.Lamia:
            case HomeWorld.Leviathan:
            case HomeWorld.Ultros:
                return DataCenterLogical.Primal;
            case HomeWorld.Aegis:
            case HomeWorld.Atomos:
            case HomeWorld.Carbuncle:
            case HomeWorld.Garuda:
            case HomeWorld.Gungnir:
            case HomeWorld.Kujata:
            case HomeWorld.Tonberry:
            case HomeWorld.Typhon:
                return DataCenterLogical.Elemental;
            case HomeWorld.Alexander:
            case HomeWorld.Bahamut:
            case HomeWorld.Durandal:
            case HomeWorld.Fenrir:
            case HomeWorld.Ifrit:
            case HomeWorld.Ridill:
            case HomeWorld.Tiamat:
            case HomeWorld.Ultima:
                return DataCenterLogical.Gaia;
            case HomeWorld.Anima:
            case HomeWorld.Asura:
            case HomeWorld.Chocobo:
            case HomeWorld.Hades:
            case HomeWorld.Ixion:
            case HomeWorld.Masamune:
            case HomeWorld.Pandaemonium:
            case HomeWorld.Titan:
                return DataCenterLogical.Mana;
            case HomeWorld.Belias:
            case HomeWorld.Mandragora:
            case HomeWorld.Ramuh:
            case HomeWorld.Shinryu:
            case HomeWorld.Unicorn:
            case HomeWorld.Valefor:
            case HomeWorld.Yojimbo:
            case HomeWorld.Zeromus:
                return DataCenterLogical.Meteor;
            default:
                throw new ArgumentOutOfRangeException(nameof(homeWorld), homeWorld, null);
        }
    }
}