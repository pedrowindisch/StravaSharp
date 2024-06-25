using System.Text.Json;
using System.Text.Json.Serialization;
using StravaSharp.Api.Models.Response;

namespace StravaSharp.Api.Commons.JsonConverters;

public class LatLngJsonConverter : JsonConverter<LatLng>
{
    public override LatLng? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType is JsonTokenType.Null)
            return null;

        if (reader.TokenType is not JsonTokenType.StartArray)
            throw new JsonException("Expected StartArray, but got " + reader.TokenType);

        var values = new List<double>();
        while (reader.Read() && reader.TokenType is not JsonTokenType.EndArray)
        {
            values.Add(reader.GetDouble());
        }

        if (values.Count is 0)
            return null;

        if (values.Count is not 2)
            throw new JsonException("Expected zero or two values, but got " + values.Count);


        return new LatLng(values[0], values[1]);
    }

    public override void Write(Utf8JsonWriter writer, LatLng value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.Latitude);
        writer.WriteNumberValue(value.Longitude);
        writer.WriteEndArray();
    }
}