using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class MovingStream
{
    [JsonPropertyName("original_size")]
    public required int OriginalSize { get; set; }

    [JsonPropertyName("resolution")]
    [AllowedValues(["low", "medium", "high"])]
    public required string Resolution { get; set; }

    [JsonPropertyName("series_type")]
    [AllowedValues(["distance", "time"])]
    public required string SeriesType { get; set; }

    [JsonPropertyName("data")]
    public required bool[] Data { get; set; } = [];
}   