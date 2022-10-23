namespace xivapi_cs.ViewModels.CharacterProfile;

public class GearPieceBase
{
    public GearPieceBase(DTOs.CharacterProfile.GearPieceBase dto)
    {
        Creator = dto.Creator;
    }

    public dynamic Creator { get; } // no clue, seems to always be null
}