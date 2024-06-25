namespace StravaSharp.Api.Commons.Extensions;

public static class DateTimeExtensions
{
    public static string ToUnixTime(this DateTime dateTime)
    {
        return new DateTimeOffset(dateTime.ToUniversalTime())
            .ToUnixTimeSeconds()
            .ToString();
    }
}