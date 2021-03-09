using System;

namespace Skybrud.Umbraco.Time.Models.TimeZones {
    
    public class TimeZone : ITimeZone {

        #region Properties

        public string Id { get; }

        public string Name { get; }

        public TimeZoneInfo TimeZoneInfo { get; }

        #endregion

        #region Constructors

        public TimeZone(string id, string name, TimeZoneInfo timeZoneInfo) {
            Id = id;
            Name = name;
            TimeZoneInfo = timeZoneInfo;
        }

        public TimeZone(TimeZoneInfo timeZoneInfo) {
            Id = timeZoneInfo.Id;
            Name = timeZoneInfo.DisplayName;
            TimeZoneInfo = timeZoneInfo;
        }

        #endregion

    }

}