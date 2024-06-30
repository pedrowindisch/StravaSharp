using StravaSharp.Auth.Models;

namespace StravaSharp.Auth.Authenticators.StaticAuthenticator;

public class StaticAuthenticator : IAuthenticator
{
    private readonly Tokens _tokens;

    public StaticAuthenticator(Tokens tokens)
    {
        _tokens = tokens;
    }

    public Task<Tokens> AuthenticateAsync()
    {
        return Task.FromResult(_tokens);
    }
}