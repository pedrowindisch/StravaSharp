using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class Fault
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("errors")]
    public Error[] Errors { get; set; } = [];
}