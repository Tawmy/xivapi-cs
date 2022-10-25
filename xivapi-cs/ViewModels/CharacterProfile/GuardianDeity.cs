using System.Text.Json.Serialization;

namespace xivapi_cs.ViewModels.CharacterProfile;

public class GuardianDeity : IconUrlAttribute
{
    internal GuardianDeity(DTOs.CharacterProfile.GuardianDeity dto) : base(dto)
    {
        GuardianDeityChild = dto.GuardianDeityChild;
    }

    [JsonPropertyName("GuardianDeity")] public dynamic GuardianDeityChild { get; } // TODO data type
}