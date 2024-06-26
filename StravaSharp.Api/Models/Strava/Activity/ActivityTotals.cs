using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class ActivityTotals
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("distance")]
    public float Distance { get; set; }

    [JsonPropertyName("moving_time")]
    public int MovingTime { get; set; }

    [JsonPropertyName("elapsed_time")]
    public int ElapsedTime { get; set; }

    [JsonPropertyName("elevation_gain")]
    public float ElevationGain { get; set; }

    [JsonPropertyName("achievement_count")]
    public int AchievementCount { get; set; }
}