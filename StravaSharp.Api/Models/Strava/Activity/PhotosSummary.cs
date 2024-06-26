using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class PhotosSummary
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("primary")]
    public PhotosSummaryPrimary? Primary { get; set; }
}