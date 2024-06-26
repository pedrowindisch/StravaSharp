using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class Route
{
    [JsonPropertyName("athlete")]
    public required SummaryAthlete Athlete { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("elevation_gain")]
    public double ElevationGain { get; set; }

    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("id_str")]
    public required string IdStr { get; set; }

    [JsonPropertyName("map")]
    public required PolylineMap Map { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("private")]
    public bool Private { get; set; }

    [JsonPropertyName("starred")]
    public bool Starred { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("type")]
    [AllowedValues([1, 2])]
    public required int Type { get; set; }

    [JsonPropertyName("sub_type")]
    [AllowedValues([1, 2, 3, 4, 5])]
    public required int SubType { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("estimated_moving_time")]
    public int EstimatedMovingTime { get; set; }

    [JsonPropertyName("segments")]
    public required SummarySegment[] Segments { get; set; }

    [JsonPropertyName("waypoints")]
    public Waypoint[]? Waypoints { get; set; }
}