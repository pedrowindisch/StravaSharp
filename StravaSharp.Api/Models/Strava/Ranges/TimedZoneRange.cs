using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class TimedZoneRange
{
    [JsonPropertyName("min")]
    public required int Min { get; set; }

    [JsonPropertyName("max")]
    public required int Max { get; set; }   

    [JsonPropertyName("time")]
    public required int Time { get; set; }
}