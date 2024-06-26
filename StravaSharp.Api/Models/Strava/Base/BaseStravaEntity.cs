using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public abstract class BaseStravaEntity
{
    [JsonPropertyName("id")]
    public long Id { get; set; }


    [JsonPropertyName("resource_state")]
    public abstract ResourceState ResourceState { get; set; }
}