using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.DatePicker {
    
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Date", EditorView, ValueType = ValueTypes.String, Group = "Skybrud.dk", Icon = "icon-calendar")]
    public class DateEditor : DateTimePropertyEditor {

        internal const string EditorAlias = "Skybrud.Umbraco.Date";

        internal const string EditorView = "datepicker";

        public DateEditor(ILogger logger) : base(logger) { }
        
        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new DateConfigurationEditor();

    }

}