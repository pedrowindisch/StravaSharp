using System.Text.Json.Serialization;
using StravaSharp.Api.Commons.JsonConverters;

namespace StravaSharp.Api.Models.Strava;

public class DetailedActivity : SummaryActivity
{   
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Detailed;

    [JsonPropertyName("hide_from_home")]
    public bool HideFromHome { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("photos")]
    public PhotosSummary? Photos { get; set; }

    [JsonPropertyName("gear")]
    public SummaryGear? Gear { get; set; }

    [JsonPropertyName("calories")]
    public double Calories { get; set; }

    [JsonPropertyName("segment_efforts")]
    public required DetailedSegmentEffort[] SegmentEfforts { get; set; }

    [JsonPropertyName("device_name")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("embed_token")]
    public string? EmbedToken { get; set; }

    [JsonPropertyName("splits_metric")]
    public Split[]? SplitsMetric { get; set; }

    [JsonPropertyName("splits_standard")]
    public Split[]? SplitsStandard { get; set; }

    [JsonPropertyName("laps")]
    public Lap[]? Laps { get; set; }

    [JsonPropertyName("best_efforts")]
    public DetailedSegmentEffort[]? BestEfforts { get; set; }
}