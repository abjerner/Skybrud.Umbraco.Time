using System;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.TimeOffset {

    /// <summary>
    /// Value converter for <see cref="TimeOffsetEditor"/>.
    /// </summary>
    public class TimeOffsetValueConverter : PropertyValueConverterBase {

        /// <inheritdoc />
        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias.InvariantEquals(TimeOffsetEditor.EditorAlias);
        }

        /// <inheritdoc />
        public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview) {
            return source;
        }

        /// <inheritdoc />
        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {

            if (inter is string str && TimeSpan.TryParse(str, out TimeSpan time)) {
                return new Models.TimeOffset(time, propertyType.DataType.ConfigurationAs<TimeOffsetConfiguration>());
            }

            return null;

        }

        /// <inheritdoc />
        public override object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return inter;
        }

        /// <inheritdoc />
        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(Models.TimeOffset);
        }

    }

}