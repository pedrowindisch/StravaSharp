using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class ExplorerResponse
{
    [JsonPropertyName("segments")]
    public ExplorerSegment[] Segments { get; set; } = [];
}