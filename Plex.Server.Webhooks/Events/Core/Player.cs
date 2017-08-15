using Newtonsoft.Json;

namespace Plex.Server.Webhooks.Events.Core
{
    public class Player
    {
        [JsonProperty("local")]
        public bool Local { get; set; }

        [JsonProperty("publicAddress")]
        public string PublicAddress { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}