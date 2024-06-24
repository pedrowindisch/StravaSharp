using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class MetaClub
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("resource_state")]
    [AllowedValues([1, 2, 3])]
    public int ResourceState { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}