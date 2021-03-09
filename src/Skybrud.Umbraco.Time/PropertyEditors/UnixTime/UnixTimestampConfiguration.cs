using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.UnixTime {
        
    public class UnixTimestampConfiguration {

        [ConfigurationField("readonly", "Readonly", "boolean", Description = "Specify whether the editor should be readonly.")]
        public bool IsReadOnly { get; set; }

        [ConfigurationField("timeZone", "Time zone", "/App_Plugins/Skybrud.Time/Views/Editors/TimeZone.html", Description = "Select the time zone of the returned <strong>EssentialsTime</strong>. This does not affect the value saved in Umbraco.")]
        public string TimeZone { get; set; }

    }

}