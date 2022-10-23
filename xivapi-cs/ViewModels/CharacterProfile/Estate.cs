namespace xivapi_cs.ViewModels.CharacterProfile;

public class Estate
{
    public Estate(DTOs.CharacterProfile.Estate dto)
    {
        Greeting = dto.Greeting;
        Name = dto.Name;
        Plot = dto.Plot;
    }

    public string Greeting { get; }
    public string Name { get; }
    public string Plot { get; }
}