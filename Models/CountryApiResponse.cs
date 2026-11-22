using Newtonsoft.Json;

namespace Rezads.Models;

public class CountryApiResponse
{
    [JsonProperty("ip")]
    public string Ip { get; set; } = string.Empty;

    [JsonProperty("country")]
    public string Country { get; set; } = string.Empty;
}