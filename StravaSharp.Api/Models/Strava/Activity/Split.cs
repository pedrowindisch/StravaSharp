using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class Split 
{
    [JsonPropertyName("average_speed")]
    public double AverageSpeed { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("elapsed_time")]
    public int ElapsedTime { get; set; }

    [JsonPropertyName("elevation_difference")]
    public double ElevationDifference { get; set; }

    [JsonPropertyName("pace_zone")]
    public int PaceZone { get; set; }

    [JsonPropertyName("moving_time")]
    public int MovingTime { get; set; }

    // [JsonPropertyName("split")]
    // public int Split { get; set; }
}