using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class Error
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("field")]
    public required string Field { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}