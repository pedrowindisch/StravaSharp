using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class BaseStream
{
    [JsonPropertyName("original_size")]
    public required int OriginalSize { get; set; }

    [JsonPropertyName("resolution")]
    [AllowedValues(["low", "medium", "high"])]
    public required string Resolution { get; set; }

    [JsonPropertyName("series_type")]
    [AllowedValues(["time", "distance"])]
    public required string SeriesType { get; set; }
}