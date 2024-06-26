using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class Comment
{
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("activity_id")]
    public required long ActivityId { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("athlete")]
    public required SummaryAthlete Athlete { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }
}