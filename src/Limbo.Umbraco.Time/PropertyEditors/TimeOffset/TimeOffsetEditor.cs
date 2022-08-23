using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Time.PropertyEditors.TimeOffset {

    /// <summary>
    /// Represents a time offset property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Limbo Time Offset", EditorView, Group = "Limbo", Icon = "icon-time color-limbo", ValueType = ValueTypes.String)]
    public class TimeOffsetEditor : DataEditor {

        private readonly IIOHelper _ioHelper;

        #region Constants

        internal const string EditorAlias = "Limbo.Umbraco.Time";

        internal const string EditorView = "/App_Plugins/Limbo.Umbraco.Time/Views/Editors/TimePicker.html";

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffsetEditor"/> class.
        /// </summary>
        public TimeOffsetEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
        }

        #endregion

        #region Member methods

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() {
            return new TimeOffsetConfigurationEditor(_ioHelper);
        }

        #endregion

    }

}