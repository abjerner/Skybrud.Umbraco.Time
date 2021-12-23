using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.TimeOffset {

    /// <summary>
    /// Represents the configuration editor for the time offset value editor.
    /// </summary>
    public class TimeOffsetConfigurationEditor : ConfigurationEditor<TimeOffsetConfiguration> {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffsetConfigurationEditor"/> class.
        /// </summary>
        /// <param name="ioHelper">An <see cref="IIOHelper"/> helper.</param>
        public TimeOffsetConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

    }

}