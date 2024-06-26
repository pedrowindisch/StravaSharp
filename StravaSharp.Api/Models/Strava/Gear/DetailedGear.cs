using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class DetailedGear : SummaryGear
{
    [JsonPropertyName("resource_state")]
    public override ResourceState ResourceState { get; set; } = ResourceState.Detailed;

    [JsonPropertyName("brand_name")]
    public string? BrandName { get; set; }

    [JsonPropertyName("model_name")]
    public string? ModelName { get; set; }

    [JsonPropertyName("frame_type")]
    public string? FrameType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}