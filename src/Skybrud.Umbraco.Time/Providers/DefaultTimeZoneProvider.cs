using System;
using System.Collections.Generic;
using System.Linq;
using Skybrud.Umbraco.Time.Models.TimeZones;
using TimeZone = Skybrud.Umbraco.Time.Models.TimeZones.TimeZone;

namespace Skybrud.Umbraco.Time.Providers {
    
    public class DefaultTimeZoneProvider : ITimeZoneProvider {

        private List<ITimeZone> _timeZones;

        #region Member methods

        public virtual IEnumerable<ITimeZone> GetTimeZones() {
            return _timeZones ?? (_timeZones = GetTimeZonesInternal().ToList());
        }

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