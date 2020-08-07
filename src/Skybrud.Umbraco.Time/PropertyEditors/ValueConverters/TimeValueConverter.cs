using System;
using Skybrud.Umbraco.Time.Models;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.ValueConverters {
    
    public class TimeValueConverter : PropertyValueConverterBase {

        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias.InvariantEquals(TimePropertyEditor.EditorAlias);
        }

        public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview) {
            return source;
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {



            if (inter is string str && TimeSpan.TryParse(str, out TimeSpan time)) {
                return new TimeOffset(time, propertyType.DataType.ConfigurationAs<TimeConfiguration>());
            }

            return null;

        }

        public override object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return inter;
        }

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(TimeOffset[]);
        }

    }

}