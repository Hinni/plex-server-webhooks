using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Plex.Server.Webhooks.Extensions;

namespace Plex.Server.Webhooks.Converters
{
    public class EventTypeConverter : StringEnumConverter
    {
        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String) return base.ReadJson(reader, objectType, existingValue, serializer);

            string enumText = reader.Value?.ToString();
            var result = enumText.GetEventType();
            if (result == null) throw new NotImplementedException($"Event {enumText} is not implemented yet.");

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}
