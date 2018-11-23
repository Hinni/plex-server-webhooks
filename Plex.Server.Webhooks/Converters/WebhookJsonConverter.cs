using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Plex.Server.Webhooks.Events;
using System;
using System.Collections.Generic;

namespace Plex.Server.Webhooks.Converters
{
    public class WebhookJsonConverter : JsonConverter
    {
        private static readonly IDictionary<string, Type> TypeMapping = new Dictionary<string, Type>()
        {
            {"media.play", typeof(MediaPlay)},
            {"media.pause", typeof(MediaPause)},
            {"media.resume", typeof(MediaResume)},
            {"media.stop", typeof(MediaStop)},
            {"media.scrobble", typeof(MediaScrobble)},
            {"media.rate", typeof(MediaRate)},
        };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException("The webhook JSON converter does not support write operations.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);

            //serialise based on the event type
            JToken eventName = null;
            jsonObject.TryGetValue("event", StringComparison.CurrentCultureIgnoreCase, out eventName);

            if (!TypeMapping.ContainsKey(eventName.ToString()))
            {
                throw new NotImplementedException(string.Format("Event {0} is not implemented yet.", eventName));
            }

            Type type = TypeMapping[eventName.ToString()];
            WebhookEventBase webhookItem = (WebhookEventBase)jsonObject.ToObject(type, serializer);

            return webhookItem;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(WebhookEventBase);
        }
    }
}