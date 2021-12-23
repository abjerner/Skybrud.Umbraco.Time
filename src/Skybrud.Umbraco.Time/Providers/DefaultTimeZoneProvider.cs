using System;
using System.Collections.Generic;
using System.Linq;
using Skybrud.Umbraco.Time.Models.TimeZones;
using TimeZone = Skybrud.Umbraco.Time.Models.TimeZones.TimeZone;

namespace Skybrud.Umbraco.Time.Providers {

    /// <summary>
    /// Default implementation for a time zone provider.
    /// </summary>
    public class DefaultTimeZoneProvider : ITimeZoneProvider {

        private List<ITimeZone> _timeZones;

        #region Member methods

        /// <summary>
        /// Returns the time zones of the provider.
        /// </summary>
        /// <returns>A collection of <see cref="ITimeZone"/>.</returns>
        public virtual IEnumerable<ITimeZone> GetTimeZones() {
            return _timeZones ?? (_timeZones = GetTimeZonesInternal().ToList());
        }

        /// <summary>
        /// Gets the time zone with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The unique identifier of the time zone.</param>
        /// <param name="result">When this method returns, contains the time zone with the specified <paramref name="id"/>, if the time zone is found; otherwise <c>null</c>. This parameter is passed uninitialized.</param>
        /// <returns><c>true</c> if provider contains a time zone with the specified <paramref name="id"/>; otherwise <c>false</c>.</returns>
        public virtual bool TryGetTimeZone(string id, out ITimeZone result) {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id));
            result = GetTimeZones().FirstOrDefault(x => x.Id == id);
            return result != null;
        }

        private IEnumerable<ITimeZone> GetTimeZonesInternal() {

            yield return new TimeZone("local", $"Server time zone: {TimeZoneInfo.Local.DisplayName}", TimeZoneInfo.Local);

            yield return new TimeZone("UTC", "(UTC) Coordinated Universal Time", TimeZoneInfo.Utc);

            foreach (TimeZoneInfo timeZone in TimeZoneInfo.GetSystemTimeZones()) {

                if (timeZone.Equals(TimeZoneInfo.Utc)) continue;

                yield return new TimeZone(timeZone);

            }

        }

        #endregion

    }

}