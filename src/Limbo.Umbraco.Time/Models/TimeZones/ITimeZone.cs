using System;
using Newtonsoft.Json;

namespace Limbo.Umbraco.Time.Models.TimeZones {

    /// <summary>
    /// Interface representing a time zone.
    /// </summary>
    public interface ITimeZone {

        /// <summary>
        /// Gets unique identifier of the time zone.
        /// </summary>
        [JsonProperty("id")]
        string Id { get; }

        /// <summary>
        /// Gets the friendly name of the time zone.
        /// </summary>
        [JsonProperty("name")]
        string Name { get; }

        /// <summary>
        /// Gets the underlying <see cref="System.TimeZoneInfo"/> representing the time zone.
        /// </summary>
        [JsonIgnore]
        TimeZoneInfo TimeZoneInfo { get; }

    }

}