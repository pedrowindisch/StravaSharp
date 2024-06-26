using System.Text.Json.Serialization;

namespace StravaSharp.Api.Models.Strava;

public class StreamSet
{
    [JsonPropertyName("time")]
    public TimeStream? Time { get; set; }

    [JsonPropertyName("distance")]
    public DistanceStream? Distance { get; set; }

    [JsonPropertyName("latlng")]
    public LatLngStream? LatLng { get; set; }

    [JsonPropertyName("altitude")]
    public AltitudeStream? Altitude { get; set; }

    [JsonPropertyName("velocity_smooth")]
    public SmoothVelocityStream? VelocitySmooth { get; set; }

    [JsonPropertyName("heartrate")]
    public HeartrateStream? Heartrate { get; set; }

    [JsonPropertyName("cadence")]
    public CadenceStream? Cadence { get; set; }

    [JsonPropertyName("watts")]
    public PowerStream? Watts { get; set; }

    [JsonPropertyName("temp")]
    public TemperatureStream? Temp { get; set; }

    [JsonPropertyName("moving")]
    public MovingStream? Moving { get; set; }

    [JsonPropertyName("grade_smooth")]
    public SmoothGradeStream? GradeSmooth { get; set; }
}