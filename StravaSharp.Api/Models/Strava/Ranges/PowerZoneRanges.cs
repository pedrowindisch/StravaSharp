using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class PowerZoneRanges
{
    [JsonPropertyName("zones")]
    public required ZoneRange[] Zones { get; set; }
}