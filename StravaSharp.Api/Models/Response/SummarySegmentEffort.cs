using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class SummarySegmentEffort
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("activity_id")]
    public long ActivityId { get; set; }

    [JsonPropertyName("elapsed_time")]
    public int ElapsedTime { get; set; }

    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("start_date_local")]
    public DateTime StartDateLocal { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("is_kom")]
    public bool IsKom { get; set; }
}