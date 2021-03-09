using System;
using Skybrud.Essentials.Time;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Core.PropertyEditors.ValueConverters;

namespace Skybrud.Umbraco.Time.PropertyEditors.DatePicker {
    
    public class DateValueConverter : DatePickerValueConverter {

        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias.InvariantEquals(DatePropertyEditor.EditorAlias);
        }

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(EssentialsDate);
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return inter is DateTime date && date > DateTime.MinValue ? new EssentialsDate(date) : null;
        }

    }

}