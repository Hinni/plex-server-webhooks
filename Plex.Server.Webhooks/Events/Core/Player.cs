using Newtonsoft.Json;

namespace Plex.Server.Webhooks.Events.Core
{
    /// <summary>
    /// Represents the Player (device)
    /// </summary>
    public class Player
    {
        /// <summary>The Id</summary>
        [JsonProperty("uuid")]
        public string Id { get; set; }

        /// <summary>The Name</summary>
        [JsonProperty("title")]
        public string Name { get; set; }

        /// <summary>Is Local</summary>
        [JsonProperty("local")]
        public bool Local { get; set; }

        /// <summary>The Public Address</summary>
        [JsonProperty("publicAddress")]
        public string PublicAddress { get; set; }
    }
}