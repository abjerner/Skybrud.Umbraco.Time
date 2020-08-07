using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors {
    
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Date", EditorView, ValueType = ValueTypes.DateTime, Group = "Skybrud.dk", Icon = "icon-calendar")]
    public class DatePropertyEditor : DateTimePropertyEditor {

        internal const string EditorAlias = "Skybrud.Umbraco.Date";

        internal const string EditorView = "datepicker";

        public DatePropertyEditor(ILogger logger) : base(logger) { }
        
        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new DateConfigurationEditor();

    }

}