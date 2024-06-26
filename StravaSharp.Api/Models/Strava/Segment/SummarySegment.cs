using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using StravaSharp.Api.Commons.JsonConverters;

namespace StravaSharp.Api.Models.Strava;

public class SummarySegment : BaseStravaEntity
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Summary;

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("activity_type")]
    [AllowedValues(["Ride", "Run"])]
    public required string ActivityType { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("average_grade")]
    public double AverageGrade { get; set; }

    [JsonPropertyName("maximum_grade")]
    public double MaximumGrade { get; set; }

    [JsonPropertyName("elevation_high")]
    public double ElevationHigh { get; set; }

    [JsonPropertyName("elevation_low")]
    public double ElevationLow { get; set; }

    [JsonPropertyName("start_latlng")]
    [JsonConverter(typeof(LatLngJsonConverter))]
    public required LatLng StartLatLng { get; set; }

    [JsonPropertyName("end_latlng")]
    [JsonConverter(typeof(LatLngJsonConverter))]
    public required LatLng EndLatLng { get; set; }

    [JsonPropertyName("climb_category")]
    [AllowedValues([0, 1, 2, 3, 4, 5])]
    public int ClimbCategory { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("state")]
    public required string State { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("private")]
    public bool Private { get; set; }

    [JsonPropertyName("athlete_pr_effort")]
    public SummaryPRSegmentEffort? AthletePrEffort { get; set; }

    [JsonPropertyName("athlete_segment_stats")]
    public SummarySegmentEffort? AthleteSegmentStats { get; set; }
}