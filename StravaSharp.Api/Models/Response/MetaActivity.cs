using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class MetaActivity
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}