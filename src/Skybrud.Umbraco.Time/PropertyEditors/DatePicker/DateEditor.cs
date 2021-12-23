using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.DatePicker {

    /// <summary>
    /// Represents a date picker property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Date", EditorView, ValueType = ValueTypes.String, Group = "Skybrud.dk", Icon = "icon-calendar color-skybrud")]
    public class DateEditor : DateTimePropertyEditor {

        #region Constants

        internal const string EditorAlias = "Skybrud.Umbraco.Date";

        internal const string EditorView = "datepicker";

        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DateEditor"/> class.
        /// </summary>

        public DateEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory, ioHelper) { }

        #endregion

        #region Member methods

        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new DateConfigurationEditor();

        #endregion

    }

}