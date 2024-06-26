using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class MetaAthlete : BaseStravaEntity
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Meta;
}