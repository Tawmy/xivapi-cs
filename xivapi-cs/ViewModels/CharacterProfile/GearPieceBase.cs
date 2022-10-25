namespace xivapi_cs.ViewModels.CharacterProfile;

public class GearPieceBase
{
    internal GearPieceBase(DTOs.CharacterProfile.GearPieceBase dto)
    {
        Creator = dto.Creator;
    }

    public object? Creator { get; } // no clue, seems to always be null
}