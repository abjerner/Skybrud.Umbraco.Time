using System;
using Skybrud.Essentials.Time;
using Limbo.Umbraco.Time.Models.TimeZones;
using Limbo.Umbraco.Time.Providers;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Extensions;

#pragma warning disable 1591

namespace Limbo.Umbraco.Time.PropertyEditors.UnixTime {

    public class UnixTimestampValueConverter : PropertyValueConverterBase {

        private readonly ITimeZoneProvider _timeZoneProvider;

        #region Constructors

        public UnixTimestampValueConverter(ITimeZoneProvider timeZoneProvider) {
            _timeZoneProvider = timeZoneProvider;
        }

        #endregion

        #region Member methods

        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias.InvariantEquals(UnixTimestampEditor.EditorAlias);
        }

        public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview) {
            return source;
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {

            if (inter is not string { Length: > 0 } str || !int.TryParse(str, out int seconds)) return null;

            // Find the selected time zone
            TimeZoneInfo timeZone = GetTimeZoneInfo(propertyType.DataType.Configuration as UnixTimestampConfiguration);

            // Convert to UNIX time from the specified seconds
            EssentialsTime timestamp = EssentialsTime.FromUnixTimestamp(seconds).ToTimeZone(timeZone);

            return timestamp;

        }

        public override object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return inter;
        }

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(EssentialsTime);
        }

        private TimeZoneInfo GetTimeZoneInfo(UnixTimestampConfiguration config) {
            if (string.IsNullOrWhiteSpace(config?.TimeZone)) return TimeZoneInfo.Local;
            return _timeZoneProvider.TryGetTimeZone(config.TimeZone, out ITimeZone result) ? result.TimeZoneInfo : TimeZoneInfo.Local;
        }

        #endregion

    }

}