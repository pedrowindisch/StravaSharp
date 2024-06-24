using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class ExplorerResponse
{
    [JsonPropertyName("segments")]
    public ExplorerSegment[] Segments { get; set; } = [];
}