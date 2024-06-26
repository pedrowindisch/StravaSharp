using System.Text.Json.Serialization;
using StravaSharp.Api.Models.Strava;

namespace StravaSharp.Api.Models.Request;

public class ActivityUpdate
{
    [JsonPropertyName("commute")]
    public bool Commute { get; set; }

    [JsonPropertyName("trainer")]
    public bool Trainer { get; set; }

    [JsonPropertyName("hide_from_home")]
    public bool HideFromHome { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ActivityType? Type { get; set; }

    [JsonPropertyName("sport_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SportType? SportType { get; set; }

    [JsonPropertyName("gear_id")]
    public string? GearId { get; set; }
}