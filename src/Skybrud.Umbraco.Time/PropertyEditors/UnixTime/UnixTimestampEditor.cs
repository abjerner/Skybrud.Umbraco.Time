using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.UnixTime {

    /// <summary>
    /// Represents a time property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Unix Timestamp", EditorView, Group = "Skybrud.dk", Icon = "icon-time", ValueType = EditorValueType)]
    public class UnixTimestampEditor : DataEditor {
        
        private readonly IIOHelper _ioHelper;

        #region Constants

        internal const string EditorAlias = "Skybrud.Umbraco.UnixTimestamp";

        internal const string EditorView = "/App_Plugins/Skybrud.Time/Views/Editors/UnixTimestamp.html";

        // Value type must be "STRING" to support zero as a value
        internal const string EditorValueType = ValueTypes.String;

        #endregion

        #region Constructors

        public UnixTimestampEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory)
        {
            _ioHelper = ioHelper;
        }

        #endregion

        #region Member methods

        protected override IConfigurationEditor CreateConfigurationEditor()  {
            return new UnixTimestampConfigurationEditor(_ioHelper);
        }

        #endregion

    }

}