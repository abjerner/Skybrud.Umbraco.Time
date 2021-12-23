using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.Time.PropertyEditors.TimeOffset {

    /// <summary>
    /// Represents the configuration for the time offset value editor.
    /// </summary>
    public class TimeOffsetConfiguration {

        /// <summary>
        /// Gets or sets the output format of the time offset value.
        /// </summary>
        [ConfigurationField("outputFormat", "Output format", "textstring", Description = "Specify the time format used when converting the property value to a string. If left blank, the format will default to <code>hh\\:mm</code>.<br /><br /><a href=\"https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-timespan-format-strings\" target=\"_blank\" rel=\"noopener\" class=\"skybrud-timepicker-link\">Read more about Custom TimeSpan format strings</a>")]
        public string OutputFormat { get; set; }

    }

}