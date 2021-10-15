using Newtonsoft.Json;

namespace Plex.Server.Webhooks.Events.Core
{
    /// <summary>
    /// Represents the User
    /// </summary>
    public class Account
    {
        /// <summary>The Id</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>The Thumbnail</summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        /// <summary>The Username</summary>
        [JsonProperty("title")]
        public string Name { get; set; }
    }
}