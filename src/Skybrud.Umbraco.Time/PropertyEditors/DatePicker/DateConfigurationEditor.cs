using System.Collections.Generic;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.DatePicker {

    public class DateConfigurationEditor : ConfigurationEditor {
        
        public override IDictionary<string, object> ToValueEditor(object configuration) {
            var d = base.ToValueEditor(configuration);
            d["format"] = "YYYY-MM-DD";
            d["pickTime"] = false;
            return d;
        }

    }

}