using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class PolylineMap
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("polyline")]
    public required string Polyline { get; set; }

    [JsonPropertyName("summary_polyline")]
    public required string SummaryPolyline { get; set; }
}