using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class SummaryGear : BaseStravaEntity
{   
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Summary;

    [JsonPropertyName("primary")]
    public bool Primary { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }
}