using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class SummaryClub : MetaClub
{
   [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Summary;

    [JsonPropertyName("profile_medium")]
    public string? ProfileMedium { get; set; }

    [JsonPropertyName("cover_photo")]
    public string? CoverPhoto { get; set; }

    [JsonPropertyName("cover_photo_small")]
    public string? CoverPhotoSmall { get; set; }

    [JsonPropertyName("sport_type")]
    [AllowedValues(["cycling", "running", "triathlon", "other"])]
    public required string SportType { get; set; }

    [JsonPropertyName("activity_types")]
    public ActivityType[]? ActivityTypes { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("private")]
    public bool Private { get; set; }

    [JsonPropertyName("member_count")]
    public int MemberCount { get; set; }

    [JsonPropertyName("featured")]
    public bool Featured { get; set; }

    [JsonPropertyName("verified")]
    public bool Verified { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}