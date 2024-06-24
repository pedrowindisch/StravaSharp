using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class ClubAthlete
{
    [JsonPropertyName("resource_state")]
    [AllowedValues([1, 2, 3])]
    public required int ResourceState { get; set; }

    [JsonPropertyName("firstname")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastname")]
    public required string LastName { get; set; }

    [JsonPropertyName("member")]
    public required string Member { get; set; }

    [JsonPropertyName("admin")]
    public bool Admin { get; set; }

    [JsonPropertyName("owner")]
    public bool Owner { get; set; }
}