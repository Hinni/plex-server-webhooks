using Newtonsoft.Json;
using Plex.Server.Webhooks.Converters;
using Plex.Server.Webhooks.Events;
using System;

namespace Plex.Server.Webhooks.Service
{
    public class WebhookParser
    {
        private readonly JsonConverter[] _converters;

        public WebhookParser()
        {
            _converters = new JsonConverter[] { new WebhookJsonConverter() };
        }

        public WebhookEventBase ParseEvent(String json)
        {
            return JsonConvert.DeserializeObject<WebhookEventBase>(json, _converters);
        }
    }
}