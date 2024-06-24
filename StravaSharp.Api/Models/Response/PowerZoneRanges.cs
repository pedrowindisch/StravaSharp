using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class PowerZoneRanges
{
    [JsonPropertyName("zones")]
    public required ZoneRange[] Zones { get; set; }
}