using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class DetailedAthlete : SummaryAthlete
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Detailed;

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