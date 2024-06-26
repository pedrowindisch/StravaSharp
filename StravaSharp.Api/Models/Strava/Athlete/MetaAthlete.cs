using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class MetaAthlete : BaseStravaEntity
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Meta;
}