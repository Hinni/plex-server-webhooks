using Newtonsoft.Json;

namespace Plex.Server.Webhooks.Events.Core
{
    /// <summary>
    /// Represents the Server
    /// </summary>
    public class Server
    {
        /// <summary>The Id</summary>
        [JsonProperty("uuid")]
        public string Id { get; set; }

        /// <summary>The Name</summary>
        [JsonProperty("title")]
        public string Name { get; set; }
    }
}