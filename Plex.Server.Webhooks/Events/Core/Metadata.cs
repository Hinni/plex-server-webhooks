using Newtonsoft.Json;
using Plex.Server.Webhooks.Converters;
using System;

namespace Plex.Server.Webhooks.Events.Core
{
    /// <summary>
    /// Represents the Metadata
    /// </summary>
    public class Metadata
    {
        /// <summary>The Library Section Type</summary>
        [JsonProperty("librarySectionType")]
        public string LibrarySectionType { get; set; }

        /// <summary>The Rating Key</summary>
        [JsonProperty("ratingKey")]
        public string RatingKey { get; set; }

        /// <summary>The Key</summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>The Parent Rating Key</summary>
        [JsonProperty("parentRatingKey")]
        public string ParentRatingKey { get; set; }

        /// <summary>The Grandparent Rating Key</summary>
        [JsonProperty("grandparentRatingKey")]
        public string GrandparentRatingKey { get; set; }

        /// <summary>The Id</summary>
        [JsonProperty("guid")]
        public string Id { get; set; }

        /// <summary>The Library Section ID</summary>
        [JsonProperty("librarySectionID")]
        public int LibrarySectionID { get; set; }

        /// <summary>The Type</summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>The Title</summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>The Grandparent Key</summary>
        [JsonProperty("grandparentKey")]
        public string GrandparentKey { get; set; }

        /// <summary>The Parent Key</summary>
        [JsonProperty("parentKey")]
        public string ParentKey { get; set; }

        /// <summary>The Grandparent Title</summary>
        [JsonProperty("grandparentTitle")]
        public string GrandparentTitle { get; set; }

        /// <summary>The Parent Title</summary>
        [JsonProperty("parentTitle")]
        public string ParentTitle { get; set; }

        /// <summary>The Summary</summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>The Index</summary>
        [JsonProperty("index")]
        public int Index { get; set; }

        /// <summary>The Parent Index</summary>
        [JsonProperty("parentIndex")]
        public int ParentIndex { get; set; }

        /// <summary>The Rating Count</summary>
        [JsonProperty("ratingCount")]
        public int RatingCount { get; set; }

        /// <summary>The Thumbnail</summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        /// <summary>The Art</summary>
        [JsonProperty("art")]
        public string Art { get; set; }

        /// <summary>The Parent Thumb</summary>
        [JsonProperty("parentThumb")]
        public string ParentThumb { get; set; }

        /// <summary>The Grandparent Thumbnail</summary>
        [JsonProperty("grandparentThumb")]
        public string GrandparentThumb { get; set; }

        /// <summary>The Grandparent Art</summary>
        [JsonProperty("grandparentArt")]
        public string GrandparentArt { get; set; }

        /// <summary>Added At</summary>
        [JsonProperty("addedAt"), JsonConverter(typeof(EpochToDateTimeConverter))]
        public DateTime AddedAt { get; set; }

        /// <summary>Updated At</summary>
        [JsonProperty("updatedAt"), JsonConverter(typeof(EpochToDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}