using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using StravaSharp.Api.Models.Strava.Base;

namespace StravaSharp.Api.Models.Strava;

public class TemperatureStream : BaseStream<int[]>
{

}