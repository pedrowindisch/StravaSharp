using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class PhotosSummary
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("primary")]
    public PhotoSummaryPrimary Primary { get; set; }
}