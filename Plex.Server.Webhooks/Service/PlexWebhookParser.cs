using System.Collections.Generic;
using Newtonsoft.Json;
using Plex.Server.Webhooks.Converters;
using Plex.Server.Webhooks.Events;

namespace Plex.Server.Webhooks.Service
{
    /// <summary>
    /// Represents the Plex Webhook Parser
    /// </summary>
    public static class PlexWebhookParser
    {
        /// <summary>
        /// Deserialize Plex Webhook data
        /// </summary>
        /// <param name="json">The incoming webhook data</param>
        /// <returns><see cref="WebhookEventBase"/> - The object</returns>
        public static PlexWebhookEvent ParseEvent(string json) =>
            JsonConvert.DeserializeObject<PlexWebhookEvent>(json);
    }
}