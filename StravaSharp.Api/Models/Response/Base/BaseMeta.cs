using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public abstract class BaseMeta
{
    [JsonPropertyName("id")]
    public long Id { get; set; }


    [JsonPropertyName("resource_state")]
    public ResourceState ResourceState { get; set; } = ResourceState.Meta;
}