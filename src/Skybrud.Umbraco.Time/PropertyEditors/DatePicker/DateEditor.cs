using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.DatePicker {
    
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Date", EditorView, ValueType = ValueTypes.String, Group = "Skybrud.dk", Icon = "icon-calendar")]
    public class DateEditor : DateTimePropertyEditor {

        internal const string EditorAlias = "Skybrud.Umbraco.Date";

        internal const string EditorView = "datepicker";

        public DateEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory, ioHelper) { }
        
        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new DateConfigurationEditor();

    }

}