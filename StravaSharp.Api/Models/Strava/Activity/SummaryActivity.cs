using System.Text.Json.Serialization;
using StravaSharp.Api.Commons.JsonConverters;

namespace StravaSharp.Api.Models.Strava;

public class SummaryActivity : MetaActivity
{

    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Summary;

    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    [JsonPropertyName("upload_id")]
    public long? UploadId { get; set; }

    [JsonPropertyName("athlete")]
    public required MetaAthlete Athlete { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("distance")]
    public required double Distance { get; set; }

    [JsonPropertyName("moving_time")]
    public required int MovingTime { get; set; }

    [JsonPropertyName("elapsed_time")]
    public required int ElapsedTime { get; set; }

    [JsonPropertyName("total_elevation_gain")]
    public required double TotalElevationGain { get; set; }

    [JsonPropertyName("elev_high")]
    public required double ElevHigh { get; set; }

    [JsonPropertyName("elev_low")]
    public required double ElevLow { get; set; }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ActivityType? Type { get; set; }

    [JsonPropertyName("sport_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SportType? SportType { get; set; }

    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("start_date_local")]
    public DateTime StartDateLocal { get; set; }

    [JsonPropertyName("timezone")]
    public required string Timezone { get; set; }

    [JsonPropertyName("start_latlng")]
    [JsonConverter(typeof(LatLngJsonConverter))]
    public required LatLng StartLatLng { get; set; }

    [JsonPropertyName("end_latlng")]
    [JsonConverter(typeof(LatLngJsonConverter))]
    public required LatLng EndLatLng { get; set; }

    [JsonPropertyName("achievement_count")]
    public int AchievementCount { get; set; }

    [JsonPropertyName("kudos_count")]
    public int KudosCount { get; set; }

    [JsonPropertyName("comment_count")]
    public int CommentCount { get; set; }

    [JsonPropertyName("athlete_count")]
    public int AthleteCount { get; set; }

    [JsonPropertyName("photo_count")]
    public int PhotoCount { get; set; }

    [JsonPropertyName("total_photo_count")]
    public int TotalPhotoCount { get; set; }

    [JsonPropertyName("map")]
    public required PolylineMap Map { get; set; }

    [JsonPropertyName("trainer")]
    public bool Trainer { get; set; }

    [JsonPropertyName("commute")]
    public bool Commute { get; set; }

    [JsonPropertyName("manual")]
    public bool Manual { get; set; }

    [JsonPropertyName("private")]
    public bool Private { get; set; }

    [JsonPropertyName("flagged")]
    public bool Flagged { get; set; }

    [JsonPropertyName("workout_type")]
    public int WorkoutType { get; set; }

    [JsonPropertyName("upload_id_str")]
    public string? UploadIdStr { get; set; }

    [JsonPropertyName("average_speed")]
    public double AverageSpeed { get; set; }

    [JsonPropertyName("max_speed")]
    public double MaxSpeed { get; set; }

    [JsonPropertyName("has_kudoed")]
    public bool HasKudoed { get; set; }

    [JsonPropertyName("gear_id")]
    public string? GearId { get; set; }

    [JsonPropertyName("kilojoules")]
    public double Kilojoules { get; set; }

    [JsonPropertyName("average_watts")]
    public double AverageWatts { get; set; }

    [JsonPropertyName("device_watts")]
    public bool DeviceWatts { get; set; }

    [JsonPropertyName("max_watts")]
    public int MaxWatts { get; set; }

    [JsonPropertyName("weighted_average_watts")]
    public int WeightedAverageWatts { get; set; }
}