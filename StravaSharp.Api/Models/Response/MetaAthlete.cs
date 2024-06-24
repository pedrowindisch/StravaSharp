using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class MetaAthlete
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}