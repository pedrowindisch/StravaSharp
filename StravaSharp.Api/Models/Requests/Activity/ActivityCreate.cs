using System.Text.Json.Serialization;
using StravaSharp.Api.Models.Response;

namespace StravaSharp.Api.Models.Request;

public class ActivityCreate
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ActivityType? Type { get; set; }

    [JsonPropertyName("sport_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SportType? SportType { get; set; }

    [JsonPropertyName("start_date_local")]
    public required DateTime StartDateLocal { get; set; }

    [JsonPropertyName("elapsed_time")]
    public required int ElapsedTime { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("distance")]
    public double? Distance { get; set; }

    [JsonPropertyName("trainer")]
    public bool Trainer { get; set; }

    [JsonPropertyName("commute")]
    public bool Commute { get; set; }
}