using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

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
        /// Initialize a new editor with the specified <paramref name="logger"/> as a dependency.
        /// </summary>
        /// <param name="logger">The logger.</param>

        public DateEditor(ILogger logger) : base(logger) { }

        #endregion

        #region Member methods

        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new DateConfigurationEditor();

        #endregion

    }

}