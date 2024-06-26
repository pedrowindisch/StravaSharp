using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class ZoneRange
{
    [JsonPropertyName("min")]
    public required int Min { get; set; }

    [JsonPropertyName("max")]
    public required int Max { get; set; }
}