# StravaSharp - A .NET library for the Strava API

StravaSharp is a .NET library for the Strava API. It is intended to provide an easy-to-use interface to interact with the Strava API, allowing you to get information about athletes, activities, and more.

> [!WARNING]
> This project is a work in progress. It is, by no means, a complete implementation of a client for the Strava API, and even less an official one. With that said, I am working on it as a learning project, and I am open to any feedback or suggestions.

## Example usage

In order to use the library, you need to create a `StravaClient` object with a valid IAuthenticator implementation. You can then use the client to make requests to the Strava API. 

The library provides two implementations of the IAuthenticator interface: `StaticAuthenticator` and `WebAuthenticator`. The `StaticAuthenticator` is used to authenticate with a static access token provided by the user, while the `WebAuthenticator` is used to authenticate with an access token obtained through a browser-based login flow. Note that the `WebAuthenticator` requires a client ID and a client secret, which you can obtain by registering your application with Strava [here](https://www.strava.com/settings/api).

Both methods are relatively simple to use. Just note that their usage is slightly different and they are not interchangeable.

```csharp
// StaticAuthenticator
var authenticator = new StaticAuthenticator("your access token");
var client = new StravaClient(authenticator);

// WebAuthenticator
var config = new StravaConfig("CLIENT_ID", "CLIENT_SECRET");
var authenticator = new WebAuthenticator(config);
var client = new StravaClient(authenticator);

// ... use the client to make requests to the Strava API
```

You can find more examples in the [samples](StravaSharp.Samples) folder.

Please note that the library is still a work in progress, and some features may not be implemented yet. One of those features is the ability to refresh an access token. This means that you will have to manually refresh the access token when it expires.

## Future plans

So far, the library only supports a few endpoints of the Strava API. I plan to add more endpoints in the future, as well as improve the existing ones.

## ...NuGet package?

The library is not yet available as a NuGet package. I don't plan to publish it, as it was created as a learning project. However, you can clone the repository and build the library yourself.

## Resources

- [Strava API documentation](https://developers.strava.com/docs/reference/)