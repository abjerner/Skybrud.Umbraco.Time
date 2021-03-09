using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.TimeOffset {

    /// <summary>
    /// Represents a time property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Time Offset", EditorView, Group = "Skybrud.dk", Icon = "icon-time", ValueType = ValueTypes.String)]
    public class TimeOffsetEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.Umbraco.Time";

        internal const string EditorView = "/App_Plugins/Skybrud.Time/Views/Editors/TimePicker.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffsetEditor"/> class.
        /// </summary>
        public TimeOffsetEditor(ILogger logger) : base(logger) { }

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TimeOffsetConfigurationEditor();

    }

}