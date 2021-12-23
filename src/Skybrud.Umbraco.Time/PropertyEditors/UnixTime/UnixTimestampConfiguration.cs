using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.UnixTime {
        
    /// <summary>
    /// Configuration for <see cref="UnixTimestampEditor"/>.
    /// </summary>
    public class UnixTimestampConfiguration {

        /// <summary>
        /// Gets or sets the unique identifer of the time zone to be used.
        /// </summary>
        [ConfigurationField("timeZone", "Time zone", "/App_Plugins/Skybrud.Time/Views/Editors/TimeZone.html", Description = "Select the time zone of the returned <strong>EssentialsTime</strong>. This does not affect the value saved in Umbraco.")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets whether the UNIX timestamp should be shown to the user.
        /// </summary>
        [ConfigurationField("showUnixTimestamp", "Show UNIX timestamp", "boolean", Description = "Show the UNIX timestamp in the editor.")]
        public bool ShowUnixTimestampp { get; set; }

        /// <summary>
        /// Gets or sets whether the field is readonly.
        /// </summary>
        [ConfigurationField("readonly", "Readonly", "boolean", Description = "Specify whether the editor should be readonly.")]
        public bool IsReadOnly { get; set; }

    }

}