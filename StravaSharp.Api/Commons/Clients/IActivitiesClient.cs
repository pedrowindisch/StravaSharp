using StravaSharp.Api.Models.Response;
using StravaSharp.Api.Models.Request;
using System.Diagnostics;

namespace StravaSharp.Api.Commons.Clients;

public interface IActivitiesClient
{
    public Task<DetailedActivity> CreateActivityAsync(ActivityCreate activity);
    public Task<DetailedActivity> GetActivityAsync(long id, bool includeAllEfforts = false);
    public Task<DetailedActivity> GetActivityCommentsAsync(long id, int? pageSize = null, string? afterCursor = null);
    public Task<DetailedActivity> GetActivityKudoersAsync(long id, int? page = null, int? perPage = null);
    public Task<DetailedActivity> GetActivityLapsAsync(long id);
    public Task<SummaryActivity[]> GetAthleteActivitiesAsync(DateTime? before = null, DateTime? after = null, int? page = null, int? perPage = null);
    public Task<DetailedActivity> GetActivityZonesAsync(long id);
    public Task<DetailedActivity> UpdateActivityAsync(long id, ActivityUpdate activity);
}