using System.Text.Json.Serialization;

namespace Rezads.Config.Models;

public class SpecialJoinConfig
{
    [JsonPropertyName("SteamID")]
    public ulong SteamID { get; set; }

    [JsonPropertyName("Message")]
    public string Message { get; set; } = string.Empty;
}
