using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using StravaSharp.Api.Models.Response.Base;

namespace StravaSharp.Api.Models.Response;

public class TemperatureStream : BaseStream<int[]>
{

}