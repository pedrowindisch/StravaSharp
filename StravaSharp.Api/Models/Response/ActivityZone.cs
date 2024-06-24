using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class ActivityZone
{
    [JsonPropertyName("score")]
    public required int Score { get; set; }

    [JsonPropertyName("distribution_buckets")]
    public DistributionBucket[] DistributionBuckets { get; set; } = [];

    [JsonPropertyName("type")]
    [AllowedValues(["heartrate", "power"])]
    public required string Type { get; set; }

    [JsonPropertyName("sensor_based")]
    public bool SensorBased { get; set; }

    [JsonPropertyName("points")]
    public int Points { get; set; }

    [JsonPropertyName("custom_zones")]
    public bool CustomZones { get; set; }

    [JsonPropertyName("max")]
    public int Max { get; set; }
}