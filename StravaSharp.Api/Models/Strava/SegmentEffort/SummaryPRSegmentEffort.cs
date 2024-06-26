using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class SummaryPRSegmentEffort
{
    [JsonPropertyName("pr_activity_id")]
    public long PrActivityId { get; set; }

    [JsonPropertyName("pr_elapsed_time")]
    public int PrElapsedTime { get; set; }

    [JsonPropertyName("pr_date")]
    public DateTime PrDate { get; set; }

    [JsonPropertyName("effort_count")]
    public int EffortCount { get; set; }
}