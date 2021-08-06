using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.UnixTime {

    public class UnixTimestampConfigurationEditor : ConfigurationEditor<UnixTimestampConfiguration> {
        
        public UnixTimestampConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

    }

}