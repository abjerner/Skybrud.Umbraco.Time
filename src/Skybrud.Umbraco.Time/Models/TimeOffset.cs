using System;
using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters;
using Skybrud.Umbraco.Time.PropertyEditors.TimeOffset;

namespace Skybrud.Umbraco.Time.Models {

    /// <summary>
    /// Class representing a time offset.
    /// </summary>
    [JsonConverter(typeof(ToStringJsonConverter))]
    public class TimeOffset {

        private readonly TimeSpan _time;

        private readonly string _format;

        #region Properties

        /// <summary>
        /// Gets the hours of the time offset.
        /// </summary>
        public int Hours => _time.Hours;

        /// <summary>
        /// Gets the minutes of the time offset.
        /// </summary>
        public int Minutes => _time.Minutes;

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize a new instance based on the specified <paramref name="time"/> and <paramref name="configuration"/>.
        /// </summary>
        /// <param name="time">A <see cref="TimeSpan"/> representing the time offset.</param>
        /// <param name="configuration">The configuration from the data type.</param>
        public TimeOffset(TimeSpan time, TimeOffsetConfiguration configuration) {
            _time = time;
            _format = string.IsNullOrWhiteSpace(configuration?.OutputFormat) ? "hh\\:mm" : configuration.OutputFormat;
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public override string ToString() {
            return _time.ToString(_format);
        }

        #endregion

    }

}