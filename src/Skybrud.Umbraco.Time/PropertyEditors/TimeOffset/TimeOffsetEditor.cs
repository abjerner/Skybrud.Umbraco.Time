﻿using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.TimeOffset {

    /// <summary>
    /// Represents a time property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Time Offset", EditorView, Group = "Skybrud.dk", Icon = "icon-time", ValueType = ValueTypes.String)]
    public class TimeOffsetEditor : DataEditor {
        
        private readonly IIOHelper _ioHelper;

        internal const string EditorAlias = "Skybrud.Umbraco.Time";

        internal const string EditorView = "/App_Plugins/Skybrud.Time/Views/Editors/TimePicker.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffsetEditor"/> class.
        /// </summary>
        public TimeOffsetEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
        }

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TimeOffsetConfigurationEditor(_ioHelper);

    }

}