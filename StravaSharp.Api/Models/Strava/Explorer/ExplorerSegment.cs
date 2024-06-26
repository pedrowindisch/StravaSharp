using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using StravaSharp.Api.Commons.JsonConverters;

namespace StravaSharp.Api.Models.Strava;

public class ExplorerSegment
{
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("climb_category")]
    [AllowedValues([0, 1, 2, 3, 4, 5])]
    public required int ClimbCategory { get; set; }

    [JsonPropertyName("climb_category_desc")]
    [AllowedValues(["NC", "4", "3", "2", "1", "HC"])]
    public required string ClimbCategoryDesc { get; set; }

    [JsonPropertyName("avg_grade")]
    public required double AvgGrade { get; set; }

    [JsonPropertyName("start_latlng")]
    [JsonConverter(typeof(LatLngJsonConverter))]
    public required LatLng StartLatLng { get; set; }

    [JsonPropertyName("end_latlng")]
    [JsonConverter(typeof(LatLngJsonConverter))]
    public required LatLng EndLatLng { get; set; }

    [JsonPropertyName("elev_difference")]
    public required double ElevDifference { get; set; }

    [JsonPropertyName("distance")]
    public required double Distance { get; set; }

    [JsonPropertyName("points")]
    public required string Points { get; set; }
}