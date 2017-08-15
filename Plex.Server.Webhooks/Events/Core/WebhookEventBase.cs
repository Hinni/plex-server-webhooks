using Newtonsoft.Json;
using Plex.Server.Webhooks.Events.Core;

namespace Plex.Server.Webhooks.Events
{
    public abstract class WebhookEventBase
    {
        [JsonProperty("event")]
        public string EventType { get; set; }

        [JsonProperty("user")]
        public bool User { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }

        [JsonProperty("Account")]
        public Account Account { get; set; }

        [JsonProperty("Server")]
        public Core.Server Server { get; set; }

        [JsonProperty("Player")]
        public Player Player { get; set; }

        [JsonProperty("Metadata")]
        public Metadata Metadata { get; set; }
    }
}