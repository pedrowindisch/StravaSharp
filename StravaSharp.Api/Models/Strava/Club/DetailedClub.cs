using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class DetailedClub : SummaryClub
{
   [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Detailed;

    [JsonPropertyName("membership")]
    [AllowedValues(["member", "pending"])]
    public string? Membership { get; set; }

    [JsonPropertyName("admin")]
    public bool Admin { get; set; }

    [JsonPropertyName("owner")]
    public bool Owner { get; set; }

    [JsonPropertyName("following_count")]
    public int FollowingCount { get; set; }
}