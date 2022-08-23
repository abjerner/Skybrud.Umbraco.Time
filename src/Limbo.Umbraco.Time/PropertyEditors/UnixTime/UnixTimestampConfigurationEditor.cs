using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Time.PropertyEditors.UnixTime {

    /// <summary>
    /// Configuration editor for <see cref="UnixTimestampEditor"/>.
    /// </summary>
    public class UnixTimestampConfigurationEditor : ConfigurationEditor<UnixTimestampConfiguration> {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnixTimestampConfigurationEditor"/> class.
        /// </summary>
        /// <param name="ioHelper">An <see cref="IIOHelper"/> helper.</param>
        public UnixTimestampConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

    }

}