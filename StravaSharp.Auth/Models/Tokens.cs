using System.Text.Json.Serialization;
using StravaSharp.Auth.Commons;

namespace StravaSharp.Auth.Models;

public class Tokens
{
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }
    
    [JsonPropertyName("refresh_token")]
    public required string RefreshToken { get; init; }
    
    [JsonPropertyName("expires_at")]
    [JsonConverter(typeof(UnixToDateTimeJsonConverter))]
    public required DateTime ExpiresAt { get; init; }
}