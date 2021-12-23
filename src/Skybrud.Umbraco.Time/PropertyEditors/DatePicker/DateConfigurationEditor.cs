using System.Collections.Generic;
using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.DatePicker {

    /// <summary>
    /// Configuration editor for <see cref="DateEditor"/>.
    /// </summary>
    public class DateConfigurationEditor : ConfigurationEditor {
        
        /// <inheritdoc />
        public override IDictionary<string, object> ToValueEditor(object configuration) {
            var d = base.ToValueEditor(configuration);
            d["format"] = "YYYY-MM-DD";
            d["pickTime"] = false;
            return d;
        }

    }

}