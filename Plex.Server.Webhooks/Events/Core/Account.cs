using Newtonsoft.Json;

namespace Plex.Server.Webhooks.Events.Core
{
    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}