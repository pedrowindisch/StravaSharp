using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class DetailedGear
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
    public required double Distance { get; set; }

    [JsonPropertyName("brand_name")]
    public string? BrandName { get; set; }

    [JsonPropertyName("model_name")]
    public string? ModelName { get; set; }

    [JsonPropertyName("frame_type")]
    public string? FrameType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}