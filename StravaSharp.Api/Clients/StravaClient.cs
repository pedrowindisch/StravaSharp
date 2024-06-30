using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Web;
using StravaSharp.Api.Commons.Clients;
using StravaSharp.Auth.Models;

namespace StravaSharp.Api.Clients;

public class StravaClient : IStravaClient, IDisposable
{
    private readonly HttpClient _httpClient;
    private Tokens _tokens;

    public IActivitiesClient Activities { get; }

    public StravaClient(Tokens tokens)
    {
        _tokens = tokens; 
        _httpClient = CreateHttpClient();

        Activities = new ActivitiesClient(this);
    }

    private HttpClient CreateHttpClient()
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://www.strava.com/api/v3/"),
            DefaultRequestHeaders =
            {
                Authorization = new AuthenticationHeaderValue("Bearer", _tokens.AccessToken)
            }
        };

        return httpClient;
    }

    private void EnsureSuccessfulResponse(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
            return;

        if (response.StatusCode == HttpStatusCode.Unauthorized)
            throw new UnauthorizedAccessException("Unathorized access: check if the access token is valid and has the required permissions");
    }

    internal async Task<T> GetAsync<T>(string url, IEnumerable<(string key, string value)>? queryParameters = null, CancellationToken cancellationToken = default)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        if (queryParameters is not null)
            foreach (var (key, value) in queryParameters)
                query[key] = value;

        var uri = $"{url}?{query}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        EnsureSuccessfulResponse(response);

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(content) ?? throw new Exception("Failed to deserialize response");
    }

    internal async Task<T> PostAsync<T>(string url, object data, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content, cancellationToken);
        EnsureSuccessfulResponse(response);

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(responseContent) ?? throw new Exception("Failed to deserialize response");
    }

    internal async Task<T> PutAsync<T>(string url, object data, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync(url, content, cancellationToken);
        EnsureSuccessfulResponse(response);

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(responseContent) ?? throw new Exception("Failed to deserialize response");
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}