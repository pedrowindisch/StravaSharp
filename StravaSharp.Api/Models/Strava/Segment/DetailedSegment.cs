using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using StravaSharp.Api.Commons.JsonConverters;

namespace StravaSharp.Api.Models.Response;

public class DetailedSegment : SummarySegment
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Detailed;

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("total_elevation_gain")]
    public double TotalElevationGain { get; set; }

    [JsonPropertyName("map")]
    public required PolylineMap Map { get; set; }

    [JsonPropertyName("effort_count")]
    public int EffortCount { get; set; }

    [JsonPropertyName("athlete_count")]
    public int AthleteCount { get; set; }

    [JsonPropertyName("hazardous")]
    public bool IsHazardous { get; set; }

    [JsonPropertyName("star_count")]
    public int StarCount { get; set; }
}