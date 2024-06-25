using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public abstract class BaseSummary : BaseMeta
{
    [JsonPropertyName("resource_state")]
    public new ResourceState ResourceState { get; set; } = ResourceState.Summary;
}