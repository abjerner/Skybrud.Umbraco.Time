using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.UnixTime {

    /// <summary>
    /// Represents a unix time property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Unix Timestamp", EditorView, Group = "Skybrud.dk", Icon = "icon-time color-skybrud", ValueType = EditorValueType)]
    public class UnixTimestampEditor : DataEditor {

        #region Constants

        internal const string EditorAlias = "Skybrud.Umbraco.UnixTimestamp";

        internal const string EditorView = "/App_Plugins/Skybrud.Time/Views/Editors/UnixTimestamp.html";

        // Value type must be "STRING" to support zero as a value
        internal const string EditorValueType = ValueTypes.String;

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize a new editor with the specified <paramref name="logger"/> as a dependency.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public UnixTimestampEditor(ILogger logger) : base(logger) { }

        #endregion

        #region Member methods

        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() {
            return new UnixTimestampConfigurationEditor();
        }

        #endregion

    }

}