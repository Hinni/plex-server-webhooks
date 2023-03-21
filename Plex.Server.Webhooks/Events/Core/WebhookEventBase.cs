using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Plex.Server.Webhooks.Converters;
using Plex.Server.Webhooks.Events.Core;

namespace Plex.Server.Webhooks.Events
{
    /// <summary>
    /// Represents the base for webhook events
    /// </summary>
    public abstract class WebhookEventBase
    {        
        /// <summary>Is User</summary>
        [JsonProperty("user")]
        public bool User { get; set; }

        /// <summary>The Event Type</summary>
        [JsonProperty("event")]
        [JsonConverter(typeof(EventTypeConverter))]
        public EventType EventType { get; set; }



        /// <summary>Is Owner</summary>
        [JsonProperty("owner")]
        public bool Owner { get; set; }

        /// <summary>The Account</summary>
        [JsonProperty("Account")]
        public Account Account { get; set; }

        /// <summary>The Server</summary>
        [JsonProperty("Server")]
        public Core.Server Server { get; set; }

        /// <summary>The Player</summary>
        [JsonProperty("Player")]
        public Player Player { get; set; }

        /// <summary>The Metadata</summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata { get; set; }
    }
}