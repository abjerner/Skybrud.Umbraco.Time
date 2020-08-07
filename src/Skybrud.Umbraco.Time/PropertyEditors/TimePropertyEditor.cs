using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors {

    /// <summary>
    /// Represents a time property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Time", EditorView, Group = "Skybrud.dk", Icon = "icon-time")]
    public class TimePropertyEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.Umbraco.Time";

        internal const string EditorView = "/App_Plugins/Skybrud.Time/Views/Editors/TimePicker.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="TimePropertyEditor"/> class.
        /// </summary>
        public TimePropertyEditor(ILogger logger) : base(logger) { }

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TimeConfigurationEditor();

    }

}