using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class Zones
{
    [JsonPropertyName("heart_rate")]
    public required HeartRateZoneRanges HeartRate { get; set; }

    [JsonPropertyName("power")]
    public required PowerZoneRanges Power { get; set; }
}