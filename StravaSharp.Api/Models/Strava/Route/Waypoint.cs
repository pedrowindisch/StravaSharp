using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class Waypoint
{
    [JsonPropertyName("latlng")]
    public required LatLng LatLng { get; set; }

    [JsonPropertyName("target_latlng")]
    public LatLng? TargetLatLng { get; set; }

    [JsonPropertyName("categories")]
    public string[] Categories { get; set; } = [];

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("distance_into_route")]
    public int DistanceIntoRoute { get; set; }
}