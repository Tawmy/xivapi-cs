namespace xivapi_cs.ViewModels.CharacterProfile;

public class GearPiece : GearPieceBase
{
    internal GearPiece(DTOs.CharacterProfile.GearPiece dto) : base(dto)
    {
        Dye = dto.Dye;
        Mirage = dto.Mirage;
        Id = dto.Id;
        Materia = dto.Materia;
    }

    public int? Dye { get; }
    public int? Mirage { get; }
    public int Id { get; }
    public int[] Materia { get; }
}