namespace xivapi_cs.ViewModels.CharacterProfile;

public class ClassJobsBozjan
{
    public ClassJobsBozjan(DTOs.CharacterProfile.ClassJobsBozjan dto)
    {
        Level = dto.Level;
        Mettle = int.TryParse(dto.Mettle?.ToString(), out var mettle) ? mettle : 0;
        Name = dto.Name;
    }

    public int? Level { get; }
    public int Mettle { get; }
    public string Name { get; }
}