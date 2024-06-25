using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public abstract class BaseDetailed : BaseSummary
{
    [JsonPropertyName("resource_state")]
    [AllowedValues([1, 2, 3])]
    public new ResourceState ResourceState { get; set; } = ResourceState.Detailed;
}