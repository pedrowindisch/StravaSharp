namespace StravaSharp.Auth.Models;

internal interface IAuthenticator
{
    public Task<Tokens> AuthenticateAsync();
}