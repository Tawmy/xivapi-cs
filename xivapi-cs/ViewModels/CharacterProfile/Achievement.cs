using System;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class Achievement
{
    internal Achievement(DTOs.CharacterProfile.Achievement dto)
    {
        Date = DateTimeOffset.FromUnixTimeSeconds(dto.Date).UtcDateTime;
        Id = dto.Id;
    }

    public DateTime Date { get; } // UTC
    public int Id { get; }
}