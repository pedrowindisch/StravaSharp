using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class SummaryGear
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("resource_state")]
    [AllowedValues([2, 3])]
    public int ResourceState { get; set; }

    [JsonPropertyName("primary")]
    public bool Primary { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }
}