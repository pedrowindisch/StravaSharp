using System.Diagnostics;
using System.Net;
using System.Text.Json;
using StravaSharp.Auth.Models;

namespace StravaSharp.Auth.Authenticators.WebAuthenticator;

public class WebAuthenticator : IAuthenticator
{
    private HttpListener? _listener;
    private StravaConfig _config;
    private int _port = 8080;

    public WebAuthenticator(StravaConfig config)
    {
        _config = config;
    }

    public WebAuthenticator(StravaConfig config, int port)
    {
        _config = config;
        _port = port;
    }

    private void StartHttpListener()
    {
        if (!HttpListener.IsSupported)
            throw new NotSupportedException("Your system does not support HttpListener, and therefore cannot use the WebAuthenticator.");
        
        var listener = new HttpListener();
        _listener = listener;

        listener.Prefixes.Add($"http://localhost:{_port}/"); 
        listener.Start();
    }

    private async Task<string> GetAuthorizationCode()
    {
        if (_listener is null || !_listener.IsListening)
            StartHttpListener();

        while (true)
        {
            var context = await _listener!.GetContextAsync();
            var request = context.Request;

            if (request is { Url: null })
                continue;

            if (!request.Url.Query.Contains("code="))
                continue;

            var query = request.Url.Query;
            var code = query.Split("code=")[1].Split("&")[0];
            
            return code;
        }
    }

    private async Task LaunchBrowser()
    {
        var url = "https://www.strava.com/oauth/authorize?" +
                  $"client_id={_config.ClientId}" +
                  $"&response_type=code" +
                  $"&redirect_uri=http://localhost:{_port}" +
                  $"&approval_prompt=force" +
                  $"&scope=read_all";

        Process.Start(new ProcessStartInfo()
        {
            FileName = url,
            UseShellExecute = true
        });
    }

    private async Task<Tokens> GetTokens(string code)
    {
        var client = new HttpClient();
        var content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["client_id"] = _config.ClientId,
            ["client_secret"] = _config.ClientSecret,
            ["code"] = code,
            ["grant_type"] = "authorization_code"
        });

        var response = await client.PostAsync("https://www.strava.com/oauth/token", content);
        var json = await response.Content.ReadAsStringAsync();
        
        var tokens = JsonSerializer.Deserialize<Tokens>(json);
        if (tokens is null)
            throw new Exception("Failed to deserialize tokens.");

        return tokens;
    }

    public async Task<Tokens> AuthenticateAsync()
    {
        await LaunchBrowser();
        var code = await GetAuthorizationCode();

        return await GetTokens(code);
    }

    public void Dispose()
    {
        if (_listener is null)
            return;

        _listener.Stop();
        _listener.Close();
    }
}