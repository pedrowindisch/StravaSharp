using StravaSharp.Api.Models.Response;
using StravaSharp.Api.Models.Request;
using System.Diagnostics;

namespace StravaSharp.Api.Commons.Clients;

public interface IActivitiesClient
{
    public Task<DetailedActivity> CreateActivityAsync(ActivityCreate activity);
    public Task<DetailedActivity> GetActivityAsync(long id, bool includeAllEfforts = false);
    public Task<Comment[]> GetActivityCommentsAsync(long id, int? pageSize = null, string? afterCursor = null);
    public Task<SummaryAthlete[]> GetActivityKudoersAsync(long id, int? page = null, int? perPage = null);
    public Task<Lap[]> GetActivityLapsAsync(long id);
    public Task<SummaryActivity[]> GetAthleteActivitiesAsync(DateTime? before = null, DateTime? after = null, int? page = null, int? perPage = null);
    public Task<ActivityZone[]> GetActivityZonesAsync(long id);
    public Task<DetailedActivity> UpdateActivityAsync(long id, ActivityUpdate activity);
}