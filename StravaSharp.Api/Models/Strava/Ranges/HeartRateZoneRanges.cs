using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class HeartRateZoneRanges
{
    [JsonPropertyName("custom_zones")]
    public bool CustomZones { get; set; }

    [JsonPropertyName("zones")]
    public required ZoneRange[] Zones { get; set; }
}