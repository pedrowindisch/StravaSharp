using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class Zones
{
    [JsonPropertyName("heart_rate")]
    public HeartRateZoneRanges HeartRate { get; set; }

    [JsonPropertyName("power")]
    public PowerZoneRanges Power { get; set; }
}