using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class MetaClub : BaseStravaEntity
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Meta;

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}