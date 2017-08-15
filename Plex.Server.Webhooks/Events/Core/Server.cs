using Newtonsoft.Json;

namespace Plex.Server.Webhooks.Events.Core
{
    public class Server
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}