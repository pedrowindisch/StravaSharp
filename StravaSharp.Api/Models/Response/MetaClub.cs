using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class MetaClub : BaseMeta
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}