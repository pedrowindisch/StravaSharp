using StravaSharp.Auth.Authenticators.WebAuthenticator;
using StravaSharp.Auth.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        RunSample().Wait();
    }

    private static async Task<Tokens> RunSample()
    {
        var config = new StravaConfig("CLIENT_ID", "CLIENT_SECRET");
        var authenticator = new WebAuthenticator(config);

        var tokens = await authenticator.AuthenticateAsync();

        Console.WriteLine($"Access token: {tokens.AccessToken}");
        Console.WriteLine($"Refresh token: {tokens.RefreshToken}");

        return tokens;
    }
}