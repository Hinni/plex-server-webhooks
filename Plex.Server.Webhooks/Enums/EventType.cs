using System.Runtime.Serialization;

namespace Plex.Server.Webhooks.Events
{
    /// <summary>
    /// Represents the event types for the Webhook being hit
    /// </summary>
    public enum EventType
    {
        #region New Content

        /// <summary>A new item is added that appears in the user’s On Deck. A poster is also attached to this event.</summary>
        [EnumMember(Value = "library.on.deck")]
        LibraryOnDeck,
        /// <summary>A new item is added to a library to which the user has access. A poster is also attached to this event.</summary>
        [EnumMember(Value = "library.new")]
        LibraryNew,

        #endregion

        #region Playback

        /// <summary>Media playback pauses.</summary>
        [EnumMember(Value = "media.pause")]
        MediaPause,
        /// <summary>Media starts playing. An appropriate poster is attached.</summary>
        [EnumMember(Value = "media.play")]
        MediaPlay,
        /// <summary>Media is rated. A poster is also attached to this event.</summary>
        [EnumMember(Value = "media.rate")]
        MediaRate,
        /// <summary>Media playback resumes.</summary>
        [EnumMember(Value = "media.resume")]
        MediaResume,
        /// <summary>Media is viewed (played past the 90% mark).</summary>
        [EnumMember(Value = "media.scrobble")]
        MediaScrobble,
        /// <summary>Media playback stops.</summary>
        [EnumMember(Value = "media.stop")]
        MediaStop,

        #endregion

        #region Server Owner

        /// <summary>A database backup is completed successfully via Scheduled Tasks.</summary>
        [EnumMember(Value = "admin.database.backup")]
        AdminDatabaseBackup,
        /// <summary>Corruption is detected in the server database.</summary>
        [EnumMember(Value = "admin.database.corrupted")]
        AdminDatabaseCorrupted,
        /// <summary>A device accesses the owner’s server for any reason, which may come from background connection testing and doesn’t necessarily indicate active browsing or playback.</summary>
        [EnumMember(Value = "device.new")]
        DeviceNew,
        /// <summary>Playback is started by a shared user for the server. A poster is also attached to this event.</summary>
        [EnumMember(Value = "playback.started")]
        PlaybackStarted

        #endregion
    }
}
