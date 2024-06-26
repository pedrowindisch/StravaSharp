using StravaSharp.Api.Commons.Clients;
using StravaSharp.Api.Commons.Extensions;
using StravaSharp.Api.Models.Request;
using StravaSharp.Api.Models.Strava;

namespace StravaSharp.Api.Clients;

internal class ActivitiesClient : IActivitiesClient
{
    private readonly StravaClient _stravaClient;

    public ActivitiesClient(StravaClient stravaClient)
    {
        _stravaClient = stravaClient;
    }

    public Task<DetailedActivity> CreateActivityAsync(ActivityCreate activity)
    {
        return _stravaClient.PostAsync<DetailedActivity>("activities", activity);
    }

    public async Task<DetailedActivity> GetActivityAsync(long id, bool includeAllEfforts = false)
    {
        return await _stravaClient.GetAsync<DetailedActivity>(
            $"activities/{id}", 
            [
                ("include_all_efforts", includeAllEfforts.ToString())
            ]
        );
    }

    public async Task<Comment[]> GetActivityCommentsAsync(long id, int? pageSize = null, string? afterCursor = null)
    {
        var queryParameters = new List<(string key, string value)>();
        if (pageSize is not null)
            queryParameters.Add(("page_size", pageSize.Value.ToString()));

        if (afterCursor is not null)
            queryParameters.Add(("after_cursor", afterCursor));

        return await _stravaClient.GetAsync<Comment[]>($"activities/{id}/comments", queryParameters);
    }

    public async Task<SummaryAthlete[]> GetActivityKudoersAsync(long id, int? page = null, int? perPage = null)
    {
        var queryParameters = new List<(string key, string value)>();
        if (page is not null)
            queryParameters.Add(("page", page.Value.ToString()));

        if (perPage is not null)
            queryParameters.Add(("per_page", perPage.Value.ToString()));

        return await _stravaClient.GetAsync<SummaryAthlete[]>($"activities/{id}/kudos", queryParameters);
    }

    public async Task<Lap[]> GetActivityLapsAsync(long id)
    {
        return await _stravaClient.GetAsync<Lap[]>($"activities/{id}/laps");
    }

    public async Task<ActivityZone[]> GetActivityZonesAsync(long id)
    {
        return await _stravaClient.GetAsync<ActivityZone[]>($"activities/{id}/zones");
    }

    public Task<SummaryActivity[]> GetAthleteActivitiesAsync(DateTime? before = null, DateTime? after = null, int? page = null, int? perPage = null)
    {
        var queryParameters = new List<(string key, string value)>();
        if (before is not null)
            queryParameters.Add(("before", before.Value.ToUnixTime()));

        if (after is not null)
            queryParameters.Add(("after", after.Value.ToUnixTime()));

        if (page is not null)
            queryParameters.Add(("page", page.Value.ToString()));

        if (perPage is not null)
            queryParameters.Add(("per_page", perPage.Value.ToString()));

        return _stravaClient.GetAsync<SummaryActivity[]>("athlete/activities", queryParameters);
    }

    public Task<DetailedActivity> UpdateActivityAsync(long id, ActivityUpdate activity)
    {
        return _stravaClient.PutAsync<DetailedActivity>($"activities/{id}", activity);
    }
}