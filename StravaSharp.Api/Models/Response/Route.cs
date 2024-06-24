using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class Route
{
    [JsonPropertyName("athlete")]
    public SummaryAthlete Athlete { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("elevation_gain")]
    public double ElevationGain { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("id_str")]
    public string IdStr { get; set; }

    [JsonPropertyName("map")]
    public PolylineMap Map { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("private")]
    public bool Private { get; set; }

    [JsonPropertyName("starred")]
    public bool Starred { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("type")]
    [AllowedValues([1, 2])]
    public string Type { get; set; }

    [JsonPropertyName("sub_type")]
    [AllowedValues([1, 2, 3, 4, 5])]
    public string SubType { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("estimated_moving_time")]
    public int EstimatedMovingTime { get; set; }

    [JsonPropertyName("segments")]
    public SummarySegments Segments { get; set; }

    [JsonPropertyName("waypoints")]
    public Waypoint Waypoints { get; set; }
}