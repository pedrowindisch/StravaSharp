using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class SummaryAthlete
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("resource_state")]
    [AllowedValues([1, 2, 3])]
    public required int ResourceState { get; set; }

    [JsonPropertyName("firstname")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastname")]
    public required string LastName { get; set; }

    [JsonPropertyName("profile_medium")]
    public string? ProfileMedium { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("sex")]
    [AllowedValues(["M", "F"])]
    public char Sex { get; set; }

    [JsonPropertyName("premium")]
    public bool? Premium { get; set; }

    [JsonPropertyName("summit")]
    public bool Summit { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}