using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class SummaryClub
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("resource_state")]
    [AllowedValues([1, 2, 3])]
    public required int ResourceState { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

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