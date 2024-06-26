using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class PolylineMap
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("resource_state")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required ResourceState ResourceState { get; set; }

    [JsonPropertyName("summary_polyline")]
    public required string SummaryPolyline { get; set; }
}