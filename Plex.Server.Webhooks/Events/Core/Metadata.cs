using Newtonsoft.Json;
using Plex.Server.Webhooks.Converters;
using System;

namespace Plex.Server.Webhooks.Events.Core
{
    public class Metadata
    {
        [JsonProperty("librarySectionType")]
        public string LibrarySectionType { get; set; }

        [JsonProperty("ratingKey")]
        public string RatingKey { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("parentRatingKey")]
        public string ParentRatingKey { get; set; }

        [JsonProperty("grandparentRatingKey")]
        public string GrandparentRatingKey { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("librarySectionID")]
        public int LibrarySectionID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("grandparentKey")]
        public string GrandparentKey { get; set; }

        [JsonProperty("parentKey")]
        public string ParentKey { get; set; }

        [JsonProperty("grandparentTitle")]
        public string GrandparentTitle { get; set; }

        [JsonProperty("parentTitle")]
        public string ParentTitle { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("parentIndex")]
        public int ParentIndex { get; set; }

        [JsonProperty("ratingCount")]
        public int RatingCount { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("art")]
        public string Art { get; set; }

        [JsonProperty("parentThumb")]
        public string ParentThumb { get; set; }

        [JsonProperty("grandparentThumb")]
        public string GrandparentThumb { get; set; }

        [JsonProperty("grandparentArt")]
        public string GrandparentArt { get; set; }

        [JsonProperty("addedAt"), JsonConverter(typeof(EpochToDateTimeConverter))]
        public DateTime AddedAt { get; set; }

        [JsonProperty("updatedAt"), JsonConverter(typeof(EpochToDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}