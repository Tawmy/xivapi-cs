using System;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class Job : IconUrlAttribute
{
    internal Job(DTOs.CharacterProfile.Job dto) : base(dto)
    {
        Abbreviation = dto.Abbreviation;
        JobEnum = Enum.TryParse<Enums.Job>(Abbreviation, true, out var job) ? job : null;
    }

    public string Abbreviation { get; }
    public Enums.Job? JobEnum { get; }
}