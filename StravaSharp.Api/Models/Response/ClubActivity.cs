using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class ClubActivity
{
    [JsonPropertyName("athlete")]
    public required MetaAthlete Athlete { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("distance")]
    public float Distance { get; set; }

    [JsonPropertyName("moving_time")]
    public int MovingTime { get; set; }

    [JsonPropertyName("elapsed_time")]
    public int ElapsedTime { get; set; }

    [JsonPropertyName("total_elevation_gain")]
    public float TotalElevationGain { get; set; }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ActivityType? Type { get; set; }

    [JsonPropertyName("sport_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SportType? SportType { get; set; }

    [JsonPropertyName("workout_type")]
    public int WorkoutType { get; set; }
}