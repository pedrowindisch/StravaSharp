using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class Upload
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("id_str")]
    public required string IdStr { get; set; }

    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("activity_id")]
    public long ActivityId { get; set; }
}