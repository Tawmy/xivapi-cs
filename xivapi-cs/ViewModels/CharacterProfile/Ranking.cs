namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class Ranking
    {
        public Ranking(DTOs.CharacterProfile.Ranking dto)
        {
            Monthly = int.TryParse(dto.Monthly?.ToString(), out var monthly) ? monthly : null;
            Weekly = int.TryParse(dto.Weekly?.ToString(), out var weekly) ? weekly : null;
        }

        public int? Monthly { get; }    // null if no monthly ranking
        public int? Weekly { get; }     // null if no weekly ranking
    }
}