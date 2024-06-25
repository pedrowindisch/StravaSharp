using StravaSharp.Api.Commons.Clients;
using StravaSharp.Api.Commons.Extensions;
using StravaSharp.Api.Models.Request;
using StravaSharp.Api.Models.Response;

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

    public Task<DetailedActivity> GetActivityCommentsAsync(long id, int? pageSize = null, string? afterCursor = null)
    {
        throw new NotImplementedException();
    }

    public Task<DetailedActivity> GetActivityKudoersAsync(long id, int? page = null, int? perPage = null)
    {
        throw new NotImplementedException();
    }

    public Task<DetailedActivity> GetActivityLapsAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<DetailedActivity> GetActivityZonesAsync(long id)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}