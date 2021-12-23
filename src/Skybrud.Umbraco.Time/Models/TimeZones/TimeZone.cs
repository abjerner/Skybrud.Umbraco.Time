using System;

namespace Skybrud.Umbraco.Time.Models.TimeZones {
    
    /// <summary>
    /// Class representing a time zone.
    /// </summary>
    public class TimeZone : ITimeZone {

        #region Properties
        
        /// <summary>
        /// Gets unique identifier of the time zone.
        /// </summary>
        public string Id { get; }
        
        /// <summary>
        /// Gets the friendly name of the time zone.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Gets the underlying <see cref="System.TimeZoneInfo"/> representing the time zone.
        /// </summary>
        public TimeZoneInfo TimeZoneInfo { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new time zone based on the specified <paramref name="id"/>, <paramref name="name"/> and <paramref name="timeZoneInfo"/>.
        /// </summary>
        /// <param name="id">The unique identifer of the time zone</param>
        /// <param name="name">The friendly name of the time zone.</param>
        /// <param name="timeZoneInfo">The <see cref="System.TimeZoneInfo"/> representing the time zone.</param>
        public TimeZone(string id, string name, TimeZoneInfo timeZoneInfo) {
            Id = id;
            Name = name;
            TimeZoneInfo = timeZoneInfo;
        }

        /// <summary>
        /// Initializes a new time zone based on the specified <paramref name="timeZoneInfo"/>.
        /// </summary>
        /// <param name="timeZoneInfo">The <see cref="System.TimeZoneInfo"/> representing the time zone.</param>
        public TimeZone(TimeZoneInfo timeZoneInfo) {
            Id = timeZoneInfo.Id;
            Name = timeZoneInfo.DisplayName;
            TimeZoneInfo = timeZoneInfo;
        }

        #endregion

    }

}