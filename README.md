# StravaSharp - A .NET library for the Strava API

StravaSharp is a .NET library for the Strava API. It is intended to provide an easy-to-use interface to interact with the Strava API, allowing you to get information about athletes, activities, and more.

> [!WARNING]
> This project is a work in progress. It is, by no means, a complete implementation of a client for the Strava API, and even less an official one. With that said, I am working on it as a learning project, and I am open to any feedback or suggestions.

## Example usage

In order to use the library, you need to create a `StravaClient` object with your access token. You can then use the client to make requests to the Strava API. Please note that you need to have a valid access token to use the library - you can find more information on how to get one [here](https://developers.strava.com/docs/getting-started/). This library does not provide any functionality to get an access token [yet](#future-plans).

```csharp
StravaClient client = new StravaClient("your access token");
var activies = await client.Activities.GetAthleteActivitiesAsync();

foreach (var activity in activies)
{
    Console.WriteLine(activity.Name);
}
```

You can find more examples in the [examples](examples) folder.

## Future plans

So far, the library only supports a few endpoints of the Strava API. I plan to add more endpoints in the future, as well as improve the existing ones. I also plan to add support for getting an access token, as well as refreshing it.

## Resources

- [Strava API documentation](https://developers.strava.com/docs/reference/)