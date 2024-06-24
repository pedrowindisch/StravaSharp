using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class UpdatableActivity
{
    [JsonPropertyName("commute")]
    public bool Commute { get; set; }

    [JsonPropertyName("trainer")]
    public bool Trainer { get; set; }

    [JsonPropertyName("hide_from_home")]
    public bool HideFromHome { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public ActivityType? Type { get; set; }

    [JsonPropertyName("sport_type")]
    public SportType? SportType { get; set; }

    [JsonPropertyName("gear_id")]
    public string? GearId { get; set; }
}