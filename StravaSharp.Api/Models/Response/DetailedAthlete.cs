using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class DetailedAthlete : BaseDetailed
{
    [JsonPropertyName("firstname")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastname")]
    public required string LastName { get; set; }

    [JsonPropertyName("profile_medium")]
    public string? ProfileMedium { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("sex")]
    [AllowedValues(["M", "F"])]
    public char Sex { get; set; }

    [JsonPropertyName("premium")]
    public bool? Premium { get; set; }

    [JsonPropertyName("summit")]
    public bool Summit { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("follower_count")]
    public int FollowerCount { get; set; }

    [JsonPropertyName("friend_count")]
    public int FriendCount { get; set; }

    [JsonPropertyName("measurement_preference")]
    [AllowedValues(["feet", "meters"])]
    public required string MeasurementPreference { get; set; }

    [JsonPropertyName("ftp")]
    public int? Ftp { get; set; }

    [JsonPropertyName("weight")]
    public double? Weight { get; set; }

    [JsonPropertyName("clubs")]
    public SummaryClub[] Clubs { get; set; } = [];

    [JsonPropertyName("bikes")]
    public DetailedGear[] Bikes { get; set; } = [];

    [JsonPropertyName("shoes")]
    public DetailedGear[] Shoes { get; set; } = [];
}