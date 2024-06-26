using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class DetailedSegmentEffort : SummarySegmentEffort
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Summary;

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("activity")]
    public required MetaActivity Activity { get; set; }

    [JsonPropertyName("athlete")]
    public required MetaAthlete Athlete { get; set; }

    [JsonPropertyName("moving_time")]
    public int MovingTime { get; set; }

    [JsonPropertyName("start_index")]
    public int StartIndex { get; set; }

    [JsonPropertyName("end_index")]
    public int EndIndex { get; set; }

    [JsonPropertyName("average_cadence")]
    public double AverageCadence { get; set; }

    [JsonPropertyName("average_watts")]
    public double AverageWatts { get; set; }

    [JsonPropertyName("device_watts")]
    public bool DeviceWatts { get; set; }

    [JsonPropertyName("average_heartrate")]
    public double AverageHeartrate { get; set; }

    [JsonPropertyName("max_heartrate")]
    public double MaxHeartrate { get; set; }

    [JsonPropertyName("segment")]
    public required SummarySegment Segment { get; set; }

    [JsonPropertyName("kom_rank")]
    public int KomRank { get; set; }

    [JsonPropertyName("pr_rank")]
    public int PrRank { get; set; }

    [JsonPropertyName("hidden")]
    public bool Hidden { get; set; }
}