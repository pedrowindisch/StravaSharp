using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class PhotosSummaryPrimary
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("source")]
    public int Source { get; set; }

    [JsonPropertyName("unique_id")]
    public required string UniqueId { get; set; }

    [JsonPropertyName("urls")]
    public required string Urls { get; set; }
}