using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Response;

public class ActivityStats
{
    [JsonPropertyName("biggest_ride_distance")]
    public double BiggestRideDistance { get; set; }
    [JsonPropertyName("biggest_climb_elevation_gain")]
    public double BiggestClimbElevationGain { get; set; }

    [JsonPropertyName("recent_ride_totals")]
    public required ActivityTotals RecentRideTotals { get; set; }

    [JsonPropertyName("recent_run_totals")]
    public required ActivityTotals RecentRunTotals { get; set; }

    [JsonPropertyName("recent_swim_totals")]
    public required ActivityTotals RecentSwimTotals { get; set; }

    [JsonPropertyName("ytd_ride_totals")]
    public required ActivityTotals YearToDateRideTotals { get; set; }

    [JsonPropertyName("ytd_run_totals")]
    public required ActivityTotals YearToDateRunTotals { get; set; }

    [JsonPropertyName("ytd_swim_totals")]
    public required ActivityTotals YearToDateSwimTotals { get; set; }

    [JsonPropertyName("all_ride_totals")]
    public required ActivityTotals AllRideTotals { get; set; }

    [JsonPropertyName("all_run_totals")]
    public required ActivityTotals AllRunTotals { get; set; }

    [JsonPropertyName("all_swim_totals")]
    public required ActivityTotals AllSwimTotals { get; set; }
}