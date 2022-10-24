using System;

namespace xivapi_cs.Enums;

[Flags]
public enum CharacterProfileOptions
{
    None = 0,
    Achievements = 1 << 0,
    FreeCompany = 1 << 1,
    FreeCompanyMembers = 1 << 2,
    Friends = 1 << 3,
    MinionsMounts = 1 << 4
}