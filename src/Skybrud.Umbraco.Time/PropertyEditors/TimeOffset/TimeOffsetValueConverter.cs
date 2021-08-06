using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Extensions;

namespace Skybrud.Umbraco.Time.PropertyEditors.TimeOffset {
    
    public class TimeOffsetValueConverter : PropertyValueConverterBase {

        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias.InvariantEquals(TimeOffsetEditor.EditorAlias);
        }

        public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview) {
            return source;
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {

            if (inter is string str && TimeSpan.TryParse(str, out TimeSpan time)) {
                return new Models.TimeOffset(time, propertyType.DataType.ConfigurationAs<TimeOffsetConfiguration>());
            }

            return null;

        }

        public override object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return inter;
        }

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(Models.TimeOffset);
        }

    }

}