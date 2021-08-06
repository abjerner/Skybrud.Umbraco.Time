using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.TimeOffset {
 
    /// <summary>
    /// Represents the configuration editor for the time offset value editor.
    /// </summary>
    public class TimeOffsetConfigurationEditor : ConfigurationEditor<TimeOffsetConfiguration> {
        
        public TimeOffsetConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

    }

}