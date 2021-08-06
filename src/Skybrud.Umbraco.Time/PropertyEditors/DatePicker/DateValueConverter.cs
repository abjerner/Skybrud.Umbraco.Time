using System;
using Skybrud.Essentials.Time;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;
using Umbraco.Extensions;

namespace Skybrud.Umbraco.Time.PropertyEditors.DatePicker {
    
    public class DateValueConverter : DatePickerValueConverter {

        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias.InvariantEquals(DateEditor.EditorAlias);
        }

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(EssentialsDate);
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return inter is DateTime date && date > DateTime.MinValue ? new EssentialsDate(date) : null;
        }

    }

}